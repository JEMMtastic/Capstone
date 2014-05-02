using Capstone.Domain.Abstract;
using Capstone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Domain.Concrete
{
    public class UserRepository : UserInterface
    {

        public void AddUser(Entities.User u)
        {
            var db = new CapstoneDbContext();
            db.Users.Add(u);
            db.SaveChanges();
        }

        public Entities.User GetUser(int userId)
        {
            var db = new CapstoneDbContext();
            return (from u in db.Users
                    where u.UserId == userId
                    select u).FirstOrDefault();
        }

        public void DeleteUser(string name)
        {
            throw new NotImplementedException();
        }

        public void EditUser(string name)
        {
            throw new NotImplementedException();
        }
    }
}
