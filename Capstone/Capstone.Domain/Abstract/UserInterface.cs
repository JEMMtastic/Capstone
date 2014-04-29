using Capstone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Domain.Abstract
{
    public interface UserInterface
    {
         void AddUser(User u);
         User GetUser(string name);
         void DeleteUser(string name);
         void EditUser(string name);
    }
}
