using CharacterCreation.Data;
using CharacterCreation.Data.Entities;
using CharacterCreation.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CharacterCreation.Test.Repository
{
    public class BaseRepositoryTests
    {
        [Fact]
        public async Task Test_Create_Character()
        {
            var options = BuildInMemoryDatabase("Create_Character");

            var newCharacter = new Character
            {
                Name = "Test Name",
                UserId = 1,
                ClassId = 1
            };

            Character dbCharacter = null;
            using (var context = new CharCreationContext(options))
            {
                var baseRepo = new BaseRepository<Character>(context);
                dbCharacter = await baseRepo.CreateAsync(newCharacter);
            }

            Assert.NotNull(dbCharacter);
            Assert.Equal(1, dbCharacter.Id);
            Assert.Equal(1, dbCharacter.UserId);
            using (var context = new CharCreationContext(options))
            {
                var characterCount = await context.Characters.CountAsync();
                Assert.Equal(1, characterCount);
            }
        }

        [Fact]
        public async Task Test_Get_Character()
        {
            var options = BuildInMemoryDatabase("Get_Character");

            var characterToGet = new Character
            {
                Name = "Test Name",
                UserId = 1,
                ClassId = 1
            };

            //create character to fetch
            using (var context = new CharCreationContext(options))
            {
                context.Characters.Add(characterToGet);
                context.SaveChanges();
            }

            //test get character
            Character dbCharacter = null;
            using (var context = new CharCreationContext(options))
            {
                var baseRepo = new BaseRepository<Character>(context);
                dbCharacter = await baseRepo.GetAsync(characterToGet.Id);
            }

            Assert.NotNull(dbCharacter);
            Assert.Equal(characterToGet.Id, dbCharacter.Id);
        }

        [Fact]
        public async Task Test_Get_Characters()
        {
            var options = BuildInMemoryDatabase("Get_Characters");

            var characterToGet = new Character
            {
                Name = "Test Name",
                UserId = 1,
                ClassId = 1
            };

            var characterToGet2 = new Character
            {
                Name = "Test Name 2",
                UserId = 1,
                ClassId = 3
            };

            //create characters to fetch
            using (var context = new CharCreationContext(options))
            {
                context.Characters.Add(characterToGet);
                context.Characters.Add(characterToGet2);
                context.SaveChanges();
            }

            //test get characters
            IEnumerable<Character> dbCharacters = null;
            using (var context = new CharCreationContext(options))
            {
                var baseRepo = new BaseRepository<Character>(context);
                dbCharacters = await baseRepo.GetAsync();
            }

            Assert.NotNull(dbCharacters);
            Assert.Equal(2, dbCharacters.Count());
        }

        [Fact]
        public async Task Test_GetCharacters_OrderByIdDescending()
        {
            var options = BuildInMemoryDatabase("Get_Characters_OrderByIdDescending");

            var questionOne = new Character();
            var questionTwo = new Character();

            using (var context = new CharCreationContext(options))
            {
                context.Characters.Add(questionOne);
                context.Characters.Add(questionTwo);
                context.SaveChanges();
            }

            IEnumerable<Character> dbCharacters = null;
            Func<IQueryable<Character>, IOrderedQueryable<Character>> orderByFunc = x =>
                x.OrderByDescending(q => q.Id);
            using (var context = new CharCreationContext(options))
            {
                var baseRepo = new BaseRepository<Character>(context);
                dbCharacters = await baseRepo.GetAsync(orderBy: orderByFunc);
            }

            Assert.NotNull(dbCharacters);
            Assert.Equal(2, dbCharacters.Count());
            Assert.Equal(2, dbCharacters.First().Id);
            Assert.Equal(1, dbCharacters.Skip(1).First().Id);
        }

        [Fact]
        public async Task Test_GetCharacter_FilterById()
        {
            var options = BuildInMemoryDatabase("Get_Characters_FilterById");

            var questionList = new List<Character>()
            {
                new Character() { Id = 1 },
                new Character() { Id = 2 },
                new Character() { Id = 3 },
                new Character() { Id = 4 },
            };

            using (var context = new CharCreationContext(options))
            {
                context.Characters.AddRange(questionList);
                context.SaveChanges();
            }

            IEnumerable<Character> dbCharacters = null;
            Expression<Func<Character, bool>> filterById = x => x.Id > 2;
            using (var context = new CharCreationContext(options))
            {
                var baseRepo = new BaseRepository<Character>(context);
                dbCharacters = await baseRepo.GetAsync(filter: filterById);
            }

            Assert.NotNull(dbCharacters);
            Assert.Equal(2, dbCharacters.Count());
            Assert.Equal(3, dbCharacters.First().Id);
            Assert.Equal(4, dbCharacters.Skip(1).First().Id);
        }

        [Fact]
        public async Task Test_GetCharacters_IncludeUser()
        {
            var options = BuildInMemoryDatabase("GetCharacters_IncludeUser");

            var question = new Character()
            {
                User = new User()
            };

            using (var context = new CharCreationContext(options))
            {
                context.Characters.Add(question);
                context.SaveChanges();
            }


            IEnumerable<Character> dbCharacters = null;
            using (var context = new CharCreationContext(options))
            {
                var baseRepo = new BaseRepository<Character>(context);
                dbCharacters = await baseRepo.GetAsync(includeProperties: "User");
            }

            Assert.NotNull(dbCharacters);
            Assert.Single(dbCharacters);
            var firstCharacter = dbCharacters.First();
            Assert.NotNull(firstCharacter.User);
            Assert.Equal(1, firstCharacter.User.Id);
        }

        private DbContextOptions<CharCreationContext> BuildInMemoryDatabase(string dbName)
        {
            return new DbContextOptionsBuilder<CharCreationContext>()
                .UseInMemoryDatabase(databaseName: dbName)
                .Options;
        }
    }
}
