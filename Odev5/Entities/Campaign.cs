using Odev5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5.Entities
{
    class Campaign:IEntity
    {
        public string Name { get; set; }
        public int CampaignPrice { get; set; }
    }
}
