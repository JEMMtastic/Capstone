using Capstone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Domain.Abstract
{
    public interface StatsInfoInterface
    {
        void AddStatsInfo(StatsInfo s);
        User GetStatsInfo(int id);
        void DeleteStatsInfo(int id);
        void EditStatsInfo(int id);
    }
}
