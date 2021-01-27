using Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5.Abstract
{
    interface ISalesService
    {
        void Display(User user,Campaign campaign,Game game);
    }
}
