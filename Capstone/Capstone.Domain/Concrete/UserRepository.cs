using Capstone.Domain.Abstract;
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

        public Entities.User GetUser(string name)
        {
            throw new NotImplementedException();
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
