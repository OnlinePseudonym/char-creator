using CharacterCreation.Data.Entities;
using CharacterCreation.Data.Repository;
using CharacterCreation.Logic.Manager;
using CharacterCreation.Shared.Models;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace CharacterCreation.Test.Manager
{
    public class UserManagerTests
    {
        [Fact]
        public async Task Test_CreateUser()
        {
            var mockUser = new User
            {
                Id = 1,
                Email = "test@email.com",
                UserName = "UserName"
            };

            var mockUserRepo = new Mock<IUserRepository>();

            mockUserRepo.Setup(u => u.CreateUserAsync(It.IsAny<User>())).ReturnsAsync(mockUser);

            var userManager = new UserManager(mockUserRepo.Object);

            var userToTest = new UserDto
            {
                Email = "test@email.com",
                UserName = "UserName"
            };
            var createdUser = await userManager.CreateUserAsync(userToTest);

            Assert.Equal(1, createdUser.Id);
            mockUserRepo.Verify(u => u.CreateUserAsync(It.IsAny<User>()), Times.Once);
        }

        [Fact]
        public async Task Test_Get_User()
        {
            var mockUser = new User
            {
                Id = 1,
                Email = "test@gmail.com",
                UserName = "UserName"
            };

            var mockUserRepo = new Mock<IUserRepository>();

            mockUserRepo.Setup(u => u.GetUserAsync(It.Is<int>(u => u == 1))).ReturnsAsync(mockUser);

            var userManager = new UserManager(mockUserRepo.Object);

            var user = await userManager.GetUserAsync(1);

            Assert.Equal(1, user.Id);
            mockUserRepo.Verify(u => u.GetUserAsync(It.Is<int>(u => u == 1)), Times.Once);
        }
    }
}
