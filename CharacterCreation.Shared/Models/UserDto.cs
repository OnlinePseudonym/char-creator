using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreation.Shared.Models
{
    public class UserDto : BaseDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public IList<CharacterDto> Characters { get; set; } = new List<CharacterDto>();
    }
}
