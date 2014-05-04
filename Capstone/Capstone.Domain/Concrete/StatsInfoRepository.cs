using Capstone.Domain.Entities;
using Capstone.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Domain.Concrete
{
    public class StatsInfoRepository : StatsInfoInterface
    {
        public void AddStatsInfo(StatsInfo s)
        {
            var db = new CapstoneDbContext();
            db.StatsInfos.Add(s);
            db.SaveChanges();
        }

        public StatsInfo GetStatsInfo(int id)
        {
            throw new NotImplementedException();
        }

        public void EditStatsInfo(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<StatsInfo> StatsInfos
        {
            get { throw new NotImplementedException(); }
        }

        public void SaveStatsInfo(StatsInfo s)
        {
            var db = new CapstoneDbContext();
            if (s.StatsInfoId == 0)
                db.StatsInfos.Add(s);
            else
            {
                StatsInfo dbEntry = db.StatsInfos.Find(s.StatsInfoId);
                if (dbEntry != null)
                {
                    dbEntry.TotalSales = s.TotalSales;
                    dbEntry.AmountOfTotalSalesToCharity = s.AmountOfTotalSalesToCharity;
                    dbEntry.CashDonations = s.CashDonations;
                    dbEntry.GuestCount = s.GuestCount;
                    dbEntry.partnershipNight = s.partnershipNight;
                }
            }
            db.SaveChanges();
        }

        public StatsInfo DeleteStatsInfo(int statsInfoId)
        {
            var db = new CapstoneDbContext();
            StatsInfo dbEntry = db.StatsInfos.Find(statsInfoId);
            if (dbEntry != null)
            {
                db.StatsInfos.Remove(dbEntry);
                db.SaveChanges();
            }
            return dbEntry;
        }
    }
}
