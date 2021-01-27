using Odev5.Abstract;
using Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5.Concrete
{
    class EdevletCheckManager : IUserCheckService
    {
        bool result = false;
        public bool check(User user)
        {
            if (result==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
