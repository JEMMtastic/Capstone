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
        IQueryable<StatsInfo> StatsInfos { get; }
        void SaveStatsInfo(StatsInfo statsInfoId);
        StatsInfo DeleteStatsInfo(int statsInfoId);

        void AddStatsInfo(StatsInfo s);
        StatsInfo GetStatsInfo(int statsInfoId);
        void EditStatsInfo(int id);
    }
}
