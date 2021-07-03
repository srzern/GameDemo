using Game.Abstract;
using Game.Concrete;
using Game.Entities;
using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/////////////Müşteri\\\\\\\\\\\\\\\\");
            ICustomerService customerManager = new CustomerManager();
            Customer customer1 = new Customer
            {
                Id = 1,
                CategoryId = 3,
                FirstName = "Sezer",
                LastName = "Ako",
                DateOfBirth = new DateTime(2002, 8, 22),
                NationalityId = "12345678910"
            };
            customerManager.Add(customer1);

            Console.WriteLine("/////////////KAMPANYA\\\\\\\\\\\\\\\\");
            ICampaignService campaignManager = new CampaignManager();
            Campaign campaign1 = new Campaign
            {
                Id = 1,
                CategoryId = 3,
                CampaignName = "Gençlere Yaz Gecesi İndirimi",
                CampaignCode = "genclereyazhediyesi",
                DiscountRate = 15,
                ConditionAge = 25
            };

            campaignManager.Add(campaign1);

            Console.WriteLine("/////////////Game\\\\\\\\\\\\\\\\");
            IGamesService gamesManager = new GamesManager();
            Games game1 = new Games 
            { 
                Id = 1, 
                CategoryId = 1, 
                GamesName = "Against the Gods", 
                GamesDescription = "Kill the all gods for honor which live in High Lands .", 
                UnitInStock = 10, 
                PricePerUnit = 350 
            };
            gamesManager.Add(game1);

            Console.WriteLine("/////////////BUY A GAME\\\\\\\\\\\\\\\\");
            IPaymentService paymentManager = new PaymentManager();
            paymentManager.Buy(customer1, game1, campaign1);

            Console.WriteLine("/////////////CUSTOMER CHECK\\\\\\\\\\\\\\\\");
            ICustomerCheckService customerCheckManager = new CustomerCheckManager();
            customerCheckManager.CheckCustomerIsReal(customer1);
        }
    }
}
