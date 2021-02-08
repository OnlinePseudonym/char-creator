using CharacterCreation.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private IBaseRepository<User> _baseRepo;

        public UserRepository(IBaseRepository<User> baseRepo)
        {
            _baseRepo = baseRepo;
        }
        public async Task<User> CreateUserAsync(User user)
        {
            return await _baseRepo.CreateAsync(user);
        }
        public async Task<User> GetUserAsync(int id)
        {
            return await _baseRepo.GetAsync(id);
        }
        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _baseRepo.GetAsync();
        }
    }
}
