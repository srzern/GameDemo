using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Entities
{
    public class Campaign : EntitiesManager, IEntity
    {
        public int ConditionAge { get; set; }
        public string CampaignName { get; set; }
        public string CampaignCode { get; set; }
        public decimal DiscountRate { get; set; }
    }
}
