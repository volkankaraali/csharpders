
using metodlar;
using System;

namespace gun3
{
    class Program
    {   
        
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Kapuz";
            product2.Price = 80;
            product2.Description = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1,product2};

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("--------Metodlar---------");
            //instance-örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut", "Yeşil Armut", 12);



        }
    }
}
