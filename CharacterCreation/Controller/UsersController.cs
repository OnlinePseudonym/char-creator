using CharacterCreation.Data;
using CharacterCreation.Data.Entities;
using CharacterCreation.Logic.Manager.Interface;
using CharacterCreation.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreation.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserManager _userManager;
        public UsersController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IEnumerable<UserDto>> GetUsers()
        {
            var users = await _userManager.GetUsersAsync();
            return users;
        }

        public async Task<UserDto> CreateUser(UserDto user)
        {
            var newUser = await _userManager.CreateUserAsync(user);
            return newUser;
        }
    }
}
