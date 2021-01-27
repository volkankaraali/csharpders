using Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Upgrade(Campaign campaign);

    }
}
