using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Models;

namespace Test.Services
{
    public interface IUser
    {
        IList<UserSubscription> GetUsers();

        void SaveUser(UserSubscription userSubscription);
    }
}
