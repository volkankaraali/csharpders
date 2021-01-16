using System;
using System.Collections.Generic;
using System.Text;

namespace metodlar
{
    class SepetManager
    {
        //naming convention
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi: "+product.Name);
        }   

        public void Add2(string productName, string description,double price)
        {
            Console.WriteLine("Sepete Eklendi: " + productName);
        }
    }
}
