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
    public class Section4Repository : Section4Interface
    {
        CapstoneDbContext db = new CapstoneDbContext();

        public void AddSection4(Section4 s)
        {
            db.Section4s.Add(s);
            db.SaveChanges();
        }

        public Section4 GetSection4(int id)
        {
            return (from s in db.Section4s.Include("PartnershipNight")
                    where s.Section4Id == id
                    select s).FirstOrDefault();
        }

        public IQueryable<Section4> Section4s
        {
            get { return db.Section4s; }
        }

        public void SaveSection4(Section4 s)
        {
            if (s.Section4Id == 0)
                db.Section4s.Add(s);
            else
            {
                Section4 dbEntry = db.Section4s.Find(s.Section4Id);
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

        public Section4 DeleteSection4(int section4Id)
        {
            Section4 dbEntry = db.Section4s.Find(section4Id);
            if (dbEntry != null)
            {
                db.Section4s.Remove(dbEntry);
                db.SaveChanges();
            }
            return dbEntry;
        }
    }
}
