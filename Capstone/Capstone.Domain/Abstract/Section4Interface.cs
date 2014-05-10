using Capstone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Domain.Abstract
{
    public interface Section4Interface
    {
        void AddSection4(Section4 s);
        IQueryable<Section4> Section4s { get; }
        void SaveSection4(Section4 section4Id);
        Section4 DeleteSection4(int section4Id);
    }
}
