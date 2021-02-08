using CharacterCreation.Data.Entities;
using CharacterCreation.Logic.Mapper;
using CharacterCreation.Shared.Models;
using System;
using Xunit;

namespace CharacterCreation.Test.Mapper
{
    public class UserMapperTests
    {
        [Fact]
        public void Test_User_To_UserDto()
        {
            var user = new User
            {
                Id = 1,
                CreatedDate = DateTime.UtcNow,
                Email = "testEmail1",
                UpdatedDate = DateTime.UtcNow,
                UserName = "testUsername"
            };

            var userDto = UserMapper.ToDto(user);

            Assert.NotNull(userDto);
            Assert.Equal(user.Id, userDto.Id);
            Assert.Equal(user.CreatedDate, userDto.CreatedDate);
            Assert.Equal(user.Email, userDto.Email);
            Assert.Equal(user.UpdatedDate, userDto.UpdatedDate);
            Assert.Equal(user.UserName, userDto.UserName);
        }

        [Fact]
        public void Test_UserDto_To_User()
        {
            var userDto = new UserDto
            {
                Id = 1,
                CreatedDate = DateTime.UtcNow,
                Email = "testEmail1",
                UpdatedDate = DateTime.UtcNow,
                UserName = "testUsername"
            };

            var user = UserMapper.ToDb(userDto);

            Assert.NotNull(user);
            Assert.Equal(userDto.Id, user.Id);
            Assert.Equal(userDto.CreatedDate, user.CreatedDate);
            Assert.Equal(userDto.Email, user.Email);
            Assert.Equal(userDto.UpdatedDate, user.UpdatedDate);
            Assert.Equal(userDto.UserName, user.UserName);
        }
    }
}
