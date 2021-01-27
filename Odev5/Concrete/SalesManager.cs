using Odev5.Abstract;
using Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5.Concrete
{
    class SalesManager : ISalesService
    {
        public void Display(User user, Campaign campaign,Game game)
        {
            Console.WriteLine("{0} isimli kullanıcı {1} oyununu {2} kampanya ile satın aldı.",user.Name,game.Name,campaign.Name);
        }
    }
}
