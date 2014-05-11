using Capstone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Domain.Abstract
{
    public interface Section3Interface
    {
        void AddSection3(Section3 sec3);
        Section3 GetSection3ById(int id);
        IQueryable<Section3> GetSection3s();
        void UpdateSection3(Section3 sec3);
        Section3 DeleteSection3(int id);
    }
}
