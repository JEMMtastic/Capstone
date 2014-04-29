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

        public PartnershipNight GetPartnershipNightById(string eventId)
        {
            throw new NotImplementedException();
        }

        public PartnershipNight GetPartnershipNightByDate(DateTime date, BvLocation loc)
        {
            throw new NotImplementedException();
        }

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

        public PartnershipNight UpdatePartnershipNight(PartnershipNight pn)
        {
            throw new NotImplementedException();
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
