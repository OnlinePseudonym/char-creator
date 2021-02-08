using CharacterCreation.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation.Logic.Manager.Interface
{
    public interface IUserManager
    {
        Task<UserDto> CreateUserAsync(UserDto user);
        Task<UserDto> GetUserAsync(int id);
        Task<IEnumerable<UserDto>> GetUsersAsync();
    }
}
