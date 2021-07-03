using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    class PaymentManager : IPaymentService
    {
        public void Buy(Customer customer, Games game, Campaign campaign)
        {
            var today = DateTime.Today;
            var age = today.Year - customer.DateOfBirth.Year;
            if (customer.DateOfBirth.Date > today.AddYears(-age)) age--;

            Console.WriteLine(age);
            Console.WriteLine(game.GamesName + "\n"+game.GamesDescription+"\n"+"İşlem ücreti: "+game.PricePerUnit);
            Console.WriteLine("Kampanya Kodu giriniz: "+campaign.CampaignCode+"\n"+campaign.CampaignName);
            Console.WriteLine("Kampanya şartının sağlanıp sağlanmadığı test ediliyor");
            if (age <= campaign.ConditionAge)
            { Console.WriteLine("Yeni Fiyat: " + (game.PricePerUnit - (game.PricePerUnit * campaign.DiscountRate / 100)) + "\n" + "Kalan ürün miktarı: " + (game.UnitInStock - 1)); }



        }

    }
  
}
