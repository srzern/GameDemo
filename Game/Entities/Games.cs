using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Entities
{
    public class Games : EntitiesManager, IEntity
    {
        public string GamesName { get; set; }
        public string GamesDescription { get; set; }
        public int UnitInStock { get; set; }
        public int PricePerUnit { get; set; }
    }
}
