using Odev5.Abstract;
using Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5.Concrete
{
    public class UserManager : IUserService
    {
        public void Add(User person)
        {
            bool result;
            EdevletCheckManager query = new EdevletCheckManager();
            result=query.check(person);
            if (result==true)
            {
                Console.WriteLine("saved " + person.Name);
            }
            else
            {
                Console.WriteLine("User ({0}) does not save.",person.Name);
            }
            

        }

        public void Delete(User person)
        {
            Console.WriteLine("deleted "+person.Name);
        }

        public void Upgrade(User person)
        {
            Console.WriteLine("updated "+person.Name);
        }
    }
}
