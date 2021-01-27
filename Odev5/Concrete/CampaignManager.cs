using Odev5.Abstract;
using Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} is added.",campaign.Name);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} is deleted.", campaign.Name);
        }

        public void Upgrade(Campaign campaign)
        {
            Console.WriteLine("{0} is upgraded.", campaign.Name);
        }
    }
}
