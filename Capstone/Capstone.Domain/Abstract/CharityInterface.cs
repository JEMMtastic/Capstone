using Capstone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Domain.Abstract
{
    public interface CharityInterface
    {
        void AddCharity(Charity c);
        Charity GetCharity(string name);
    }
}
