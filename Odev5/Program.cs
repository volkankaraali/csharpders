using Odev5.Abstract;
using Odev5.Concrete;
using Odev5.Entities;
using System;

namespace Odev5
{
    public class Program
    {
        static void Main(string[] args)
        {
            IUserService userService = new UserManager();
            ICampaignService campaignService = new CampaignManager();
            ISalesService salesService = new SalesManager();
            
            User person1 = new User() {Id=1,Name="Volkan",Surname="Karaali",NationaltyNo="1234567890",BirthOfDate="1997"};
            Campaign campaign1 = new Campaign() {Id=1,Name="Yaz İndirimi",CampaignPrice=50};
            Game game1 = new Game() {Id=1,Name="CSGO",GamePrice=20};
            
            
            
            campaignService.Add(campaign1);
            campaignService.Delete(campaign1);
            campaignService.Upgrade(campaign1);
            Console.WriteLine("");
            salesService.Display(person1, campaign1, game1);
            Console.WriteLine("");
            userService.Add(person1);
            userService.Delete(person1);
            userService.Upgrade(person1);

          

        }
    }
}
