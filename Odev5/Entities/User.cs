using Odev5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5.Entities
{
    public class User:IEntity
    {
        public string NationaltyNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthOfDate { get; set; }

        
    }
}
