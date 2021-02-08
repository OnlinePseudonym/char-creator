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
    public class CharactersController : ControllerBase
    {
        private CharCreationContext _context;
        public CharactersController(CharCreationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<CharacterDto>> GetCharacters()
        {
            var dbChars = await _context.Characters.ToListAsync();
            var dtoChars = dbChars.Select(character => new CharacterDto()
            {
                Id = character.Id,
                Name = character.Name,
                ClassId = character.ClassId,
                Strength = character.Strength,
                Dexterity = character.Dexterity,
                Constitution = character.Constitution,
                Intelligence = character.Intelligence,
                Spirit = character.Spirit,
                UserId = character.UserId,
                CreatedDate = character.CreatedDate,
                UpdatedDate = character.UpdatedDate
            });

            return dtoChars;
        }

        public async Task<CharacterDto> CreateCharacter(CharacterDto character)
        {
            var dbCharacter = new Character()
            {
                Name = character.Name,
                ClassId = character.ClassId,
                Strength = character.Strength,
                Dexterity = character.Dexterity,
                Constitution = character.Constitution,
                Intelligence = character.Intelligence,
                Spirit = character.Spirit,
                UserId = character.UserId
            };
            _context.Characters.Add(dbCharacter);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return character;
        }

        [HttpGet("{Id}")]
        public async Task<CharacterDto> GetCharacter(int Id)
        {
            var character = await _context.Characters.FindAsync(Id);
            var dtoCharacter = new CharacterDto()
            {
                Id = character.Id,
                Name = character.Name,
                ClassId = character.ClassId,
                Strength = character.Strength,
                Dexterity = character.Dexterity,
                Constitution = character.Constitution,
                Intelligence = character.Intelligence,
                Spirit = character.Spirit,
                UserId = character.UserId,
                CreatedDate = character.CreatedDate,
                UpdatedDate = character.UpdatedDate
            };

            return dtoCharacter;
        }
    }
}
