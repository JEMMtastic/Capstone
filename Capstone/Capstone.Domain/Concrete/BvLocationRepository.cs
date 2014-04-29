using Capstone.Domain.Abstract;
using Capstone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Domain.Concrete
{
    public class BvLocationRepository: BvLocationInterface
    {

        public Entities.BvLocation GetBvLocation(string storeNum)
        {
            throw new NotImplementedException();
        }

        public void AddBvLocation(BvLocation bvLocation)
        {
            var db = new CapstoneDbContext();
            db.BvLocations.Add(bvLocation);
            db.SaveChanges(); ;
        }

        public void DeleteBvLocation(string storeNum)
        {
            throw new NotImplementedException();
        }

        public BvLocation EditBvLocation(string storeNum)
        {
            throw new NotImplementedException();
        }
    }
}
