using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Entities
{
    public class Customer : EntitiesManager, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
