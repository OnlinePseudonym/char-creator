using CharacterCreation.Data;
using CharacterCreation.Data.Entities;
using CharacterCreation.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreation.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseClassController : ControllerBase
    {
        private CharCreationContext _context;
        public BaseClassController(CharCreationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<BaseClassDto>> GetBaseClasses()
        {
            var dbBaseClasses = await _context.BaseClasses.ToListAsync();
            var dtoBaseClasses = dbBaseClasses.Select(c => new BaseClassDto()
            {
                Id = c.Id,
                Name = c.Name
            });

            return dtoBaseClasses;
        }

        public async Task<BaseClassDto> CreateBaseClass(BaseClassDto baseClass)
        {
            var dbBaseClass = new BaseClass()
            {
                Name = baseClass.Name
            };
            _context.BaseClasses.Add(dbBaseClass);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return baseClass;
        }
    }
}
