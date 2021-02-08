using CharacterCreation.Data;
using CharacterCreation.Data.Entities;
using CharacterCreation.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CharacterCreation.Test.Repository
{
    public class UserRepositoryTests
    {
        [Fact]
        public async Task Test_Create_User()
        {
            var options = new DbContextOptionsBuilder<CharCreationContext>()
                .UseInMemoryDatabase(databaseName: "Create_User")
                .Options;

            var newUser = new User
            {
                Email = "test@email.com",
                UserName = "userName"
            };

            int? userId = null;

            using (var context = new CharCreationContext(options))
            {
                var userRepository = new UserRepository(context);
                var user = await userRepository.CreateUserAsync(newUser);
                userId = user.Id;
            }

            Assert.NotNull(userId);

            using (var context = new CharCreationContext(options))
            {
                var userCount = await context.Users.CountAsync();
                Assert.Equal(1, userCount);
            }
        }

        [Fact]
        public async Task Test_GetUser()
        {
            var options = new DbContextOptionsBuilder<CharCreationContext>()
                .UseInMemoryDatabase(databaseName: "Get_User")
                .Options;

            var userToGet = new User
            {
                Email = "test@gmail.com",
                UserName = "userName"
            };

            //create user to fetch
            using (var context = new CharCreationContext(options))
            {
                context.Users.Add(userToGet);
                context.SaveChanges();
            }


            //test get user
            User dbUser = null;
            using (var context = new CharCreationContext(options))
            {
                var userRepo = new UserRepository(context);
                dbUser = await userRepo.GetUserAsync(userToGet.Id);
            }

            Assert.NotNull(dbUser);
            Assert.Equal(userToGet.Id, dbUser.Id);
        }
    }
}
