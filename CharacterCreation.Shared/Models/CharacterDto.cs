using System.Collections.Generic;

namespace CharacterCreation.Shared.Models
{
    public class CharacterDto : BaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassId { get; set; }
        public ClassDto Class { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Spirit { get; set; }
        public IList<StatAdjustmentDto> BaseStatAdjustments { get; set; } = new List<StatAdjustmentDto>();
        public IList<StatAdjustmentDto> MaxStatAdjustments { get; set; } = new List<StatAdjustmentDto>();
        public int UserId { get; set; }
        public UserDto User { get; set; }
    }
}
