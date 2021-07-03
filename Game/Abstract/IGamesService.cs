using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Game.Abstract
{
    public interface IGamesService
    {
        void Add(Games game);
        void Update(Games game);
        void Delete(Games game);
    }
}
