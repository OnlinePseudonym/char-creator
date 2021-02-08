using System.Collections.Generic;

namespace CharacterCreation.Data.Entities
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public IList<Character> Characters { get; set; } = new List<Character>();
    }
}
