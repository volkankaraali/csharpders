using Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5.Abstract
{
    public interface IUserService
    {
        void Add(User person);
        void Delete(User person);
        void Upgrade(User person);
    }
}
