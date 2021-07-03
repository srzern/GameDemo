using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    public class CustomerManager : ICustomerService
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " Eklendi");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " Silindi");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " Güncellendi");
        }
    }
}
