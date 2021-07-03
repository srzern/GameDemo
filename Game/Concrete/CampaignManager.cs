using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" " + campaign.DiscountRate + " Oranı ile başarıyla eklendi \n" +  "Kampanya için gereken minimum yaş şartı " + campaign.ConditionAge +"\n"+"Kampanya Kodu: "+campaign.CampaignCode);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Başarıyla Silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Başarıyla Güncellendi");
        }
    }
}
