namespace CharacterCreation.Data.Entities
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BaseClassId { get; set; }
        public BaseClass BaseClass { get; set; }
        public StatAdjustment BaseStatAdjustment { get; set; }
        public StatAdjustment MaxStatAdjustment { get; set; }
    }
}
