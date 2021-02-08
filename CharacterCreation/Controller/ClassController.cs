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
    public class ClassController : ControllerBase
    {
        private CharCreationContext _context;
        public ClassController(CharCreationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<ClassDto>> GetClasses()
        {
            var dbClasses = await _context.Classes.ToListAsync();
            var dtoClasses = dbClasses.Select(c => new ClassDto()
            {
                Id = c.Id,
                Name = c.Name
            });

            return dtoClasses;
        }

        public async Task<ClassDto> CreateClass(ClassDto classDto)
        {
            var dbClass = new Class()
            {
                Name = classDto.Name,
                BaseClassId = classDto.BaseClassId
            };
            _context.Classes.Add(dbClass);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return classDto;
        }
    }
}
