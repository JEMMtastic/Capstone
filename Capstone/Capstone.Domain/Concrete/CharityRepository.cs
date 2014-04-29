using Capstone.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Domain.Concrete
{
    public class CharityRepository : CharityInterface
    {

        public void AddCharity(Entities.Charity c)
        {
            var db = new CapstoneDbContext();
            db.Charities.Add(c);
            db.SaveChanges();
        }

        public Entities.Charity GetCharity(string name)
        {
            throw new NotImplementedException();
        }
    }
}
