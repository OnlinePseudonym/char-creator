using System.Collections.Generic;

namespace CharacterCreation.Data.Entities
{
    public class BaseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public StatAdjustment BaseStatAdjustment { get; set; }
        public StatAdjustment MaxStatAdjustment { get; set; }
        public IList<Class> PromotionClasses { get; set; } = new List<Class>();
    }
}
