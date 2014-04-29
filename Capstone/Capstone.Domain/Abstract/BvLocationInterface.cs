using Capstone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Domain.Abstract
{
    public interface BvLocationInterface
    {
         BvLocation GetBvLocation(string storeNum);
         void AddBvLocation(BvLocation bvLocation);
         void DeleteBvLocation(string storeNum);
         BvLocation EditBvLocation(string storeNum);
    }
}
