﻿using Capstone.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Domain.Concrete
{
    public class StatsInfoRepository : StatsInfoInterface
    {
        public void AddStatsInfo(Entities.StatsInfo s)
        {
            var db = new CapstoneDbContext();
            db.StatsInfos.Add(s);
            db.SaveChanges();
        }

        public Entities.StatsInfo GetStatsInfo(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteStatsInfo(int id)
        {
            throw new NotImplementedException();
        }

        public void EditStatsInfo(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Entities.StatsInfo> StatsInfos
        {
            get { throw new NotImplementedException(); }
        }

        public void SaveStatsInfo(Entities.StatsInfo statsInfoId)
        {
            throw new NotImplementedException();
        }
    }
}
