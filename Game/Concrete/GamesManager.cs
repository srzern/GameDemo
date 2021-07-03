using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    public class GamesManager : IGamesService
    {
        public void Add(Games game)
        {
            Console.WriteLine(game.GamesName+": Adlı oyun başarıyla eklenmiştir. \n" + "Açıklama: "+game.GamesDescription+"\n"+"Game Stocks: "+game.UnitInStock+"\n"+"Game Price: "+ game.PricePerUnit);
        }

        public void Delete(Games game)
        {
            Console.WriteLine(game.GamesName + ": Adlı oyun başarıyla silinmiştir.");
        }

        public void Update(Games game)
        {
            Console.WriteLine(game.GamesName + ": Adlı oyun başarıyla güncellenmiştir.");
        }
    }
}
