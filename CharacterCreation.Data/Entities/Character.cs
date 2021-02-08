using System.Collections.Generic;

namespace CharacterCreation.Data.Entities
{
    public class Character : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Spirit { get; set; }
        public IList<StatAdjustment> BaseStatAdjustments { get; set; } = new List<StatAdjustment>();
        public IList<StatAdjustment> MaxStatAdjustments { get; set; } = new List<StatAdjustment>();
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
