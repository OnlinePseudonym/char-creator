using System.Collections.Generic;

namespace CharacterCreation.Shared.Models
{
    public class BaseClassDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public StatAdjustmentDto BaseStatAdjustment { get; set; }
        public StatAdjustmentDto MaxStatAdjustment { get; set; }
        public IList<ClassDto> PromotionClasses { get; set; } = new List<ClassDto>();
    }
}
