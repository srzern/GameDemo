using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public void CheckCustomerIsReal(Customer customer)
        {
            if (customer.NationalityId.Length==11)
            {
                Console.WriteLine(customer.FirstName + " onaylandı");
            }
            else
            {
                Console.WriteLine(customer.FirstName + " onaylanamadı");
            }
        }
    }
}
