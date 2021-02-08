namespace CharacterCreation.Shared.Models
{
    public class ClassDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BaseClassId { get; set; }
        public BaseClassDto BaseClass { get; set; }
        public StatAdjustmentDto BaseStatAdjustment { get; set; }
        public StatAdjustmentDto MaxStatAdjustment { get; set; }
    }
}
