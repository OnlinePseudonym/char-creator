using CharacterCreation.Data.Repository;
using CharacterCreation.Logic.Manager.Interface;
using CharacterCreation.Logic.Mapper;
using CharacterCreation.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation.Logic.Manager
{
    public class UserManager : IUserManager
    {
        private IUserRepository _userRepo;

        public UserManager(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task<UserDto> CreateUserAsync(UserDto user)
        {
            var dbUser = UserMapper.ToDb(user);
            var createdUser = await _userRepo.CreateUserAsync(dbUser);
            return UserMapper.ToDto(createdUser);
        }

        public async Task<UserDto> GetUserAsync(int id)
        {
            var dbUser = await _userRepo.GetUserAsync(id);
            return UserMapper.ToDto(dbUser);
        }

        public Task<IEnumerable<UserDto>> GetUsersAsync()
        {
            throw new NotImplementedException();
        }
    }
}
