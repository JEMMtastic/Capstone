using Capstone.Domain.Entities;
using Capstone.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Capstone.Domain.Concrete
{
    public class StatsInfoRepository : StatsInfoInterface
    {
        CapstoneDbContext db = new CapstoneDbContext();

        public void AddStatsInfo(StatsInfo s)
        {
            db.StatsInfos.Add(s);
            db.SaveChanges();
        }

        public StatsInfo GetStatsInfo(int id)
        {
            return (from s in db.StatsInfos.Include("PartnershipNight")
                    where s.StatsInfoId == id
                    select s).FirstOrDefault();
        }

        public IQueryable<StatsInfo> StatsInfos
        {
            get { return db.StatsInfos; }
        }

        public void SaveStatsInfo(StatsInfo s)
        {
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
                    if (dbEntry.partnershipNight != null)
                    {
                        s.partnershipNight = db.PartnershipNights.Find(s.partnershipNight.PartnershipNightId);
                        dbEntry.partnershipNight = s.partnershipNight;
                    }
                    else
                    {
                        s.partnershipNight = null;
                    }
                }
            }
            db.SaveChanges();
        }

        public StatsInfo DeleteStatsInfo(int statsInfoId)
        {
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
