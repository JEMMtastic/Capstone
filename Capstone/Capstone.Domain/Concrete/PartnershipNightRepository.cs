using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Capstone.Domain.Entities;
using Capstone.Domain.Abstract;

namespace Capstone.Domain.Concrete
{
    public class PartnershipNightRepository : PartnershipNightInterface
    {
        public void AddPartnershipNight(PartnershipNight pn)
        {
            //throw new NotImplementedException();
            var db = new CapstoneDbContext();
            db.PartnershipNights.Add(pn);
            db.SaveChanges();
            //TODO: Add in error handling
        }

        public PartnershipNight GetPartnershipNightById(int eventId)
        {
            var db = new CapstoneDbContext();
            return (from pnight in db.PartnershipNights
                    where pnight.PartnershipNightId == eventId
                    select pnight).FirstOrDefault();
        }

        public PartnershipNight GetPartnershipNightByDate(DateTime date, BvLocation loc)
        {
            var db = new CapstoneDbContext();
            return (from pnight in db.PartnershipNights
                    where pnight.Date == date && pnight.BVLocation == loc
                    select pnight).FirstOrDefault();
        }

        public IQueryable<PartnershipNight> GetPartnershipNights()  //Doing it this way as per suggestion. Seems highly inefficient to me to grab all partnership nights en masse, would prefer to narrow them via some criteria. Options commented out below for the future, should we decide to implement them.
        {
            var db = new CapstoneDbContext();
            return (from pnight in db.PartnershipNights
                    select pnight).AsQueryable<PartnershipNight>();
        }
        /*
        public IQueryable<PartnershipNight> GetPartnershipNightsByMonth(DateTime extractMonthAndYear)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PartnershipNight> GetPartnershipNightsByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PartnershipNight> GetPartnershipNightsByLoc(BvLocation loc)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PartnershipNight> GetPartnershipNightsByDateRange(DateTime firstDate, DateTime lastDate, BvLocation loc)
        {
            throw new NotImplementedException();
        }
        */
        public void UpdatePartnershipNight(PartnershipNight pn)
        {
            var db = new CapstoneDbContext();
            var dbEntry = db.PartnershipNights.Find(pn);
            if (dbEntry != null)
            {
                dbEntry.Date = pn.Date;
                dbEntry.Charity = pn.Charity;
                dbEntry.BVLocation = pn.BVLocation;
                dbEntry.CheckRequestId = pn.CheckRequestId;
                dbEntry.Comments = pn.Comments;
                dbEntry.CheckRequestFinished = pn.CheckRequestFinished;
                dbEntry.BeforeTheEventFinished = pn.BeforeTheEventFinished;
                dbEntry.AfterTheEventFinished = pn.AfterTheEventFinished;
            }
            db.SaveChanges();
        }
        
        public void DeletePartnershipNight(PartnershipNight pn)
        {
            //throw new NotImplementedException();
            var db = new CapstoneDbContext();
            db.PartnershipNights.Remove(pn);
            db.SaveChanges();
            //TODO: Add in error handling
        }
    }
}
