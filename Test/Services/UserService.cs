using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Models;

namespace Test.Services
{
    public class UserService : IUser
    {
        private readonly AppDbContext _db;

        public UserService(AppDbContext db)
        {
            _db = db;
        }

        public IList<UserSubscription> GetUsers()
        {
            return _db.Users.ToList();
        }

        public void SaveUser(UserSubscription user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }
    }
}
