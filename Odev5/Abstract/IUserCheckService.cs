using Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5.Abstract
{
    interface IUserCheckService
    {
        bool check(User user);
    }
}
