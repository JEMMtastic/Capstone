using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Domain.Abstract;
using Capstone.Domain.Entities;

namespace Capstone.Domain.Concrete
{
    public class Section3Repository : Section3Interface
    {

        public void AddSection3(Section3 sec3)
        {
            var db = new CapstoneDbContext();

            db.Section3s.Add(sec3);
        }

        public Section3 GetSection3ById(int id)
        {
            var db = new CapstoneDbContext();

            return (from sec3 in db.Section3s
                    where sec3.Section3Id == id
                    select sec3).FirstOrDefault();
        }

        public IQueryable<Entities.Section3> GetSection3s()
        {
            var db = new CapstoneDbContext();

            return (from sec3 in db.Section3s
                    select sec3).AsQueryable<Section3>();
        }

        public void UpdateSection3(Entities.Section3 sec3)
        {
           var db = new CapstoneDbContext();

           if (sec3.Section3Id == 0)
           {
               db.Section3s.Add(sec3);
           }
           else
           {
               var dbEntry = db.Section3s.Find(sec3.Section3Id);
               if (dbEntry != null)
               {
                   dbEntry.Hour4Sales = sec3.Hour4Sales;
                   dbEntry.Hour5Sales = sec3.Hour5Sales;
                   dbEntry.Hour6Sales = sec3.Hour6Sales;
                   dbEntry.Hour7Sales = sec3.Hour7Sales;
                   dbEntry.Hour8Sales = sec3.Hour8Sales;
                   dbEntry.Hour4GC = sec3.Hour4GC;
                   dbEntry.Hour5GC = sec3.Hour5GC;
                   dbEntry.Hour6GC = sec3.Hour6GC;
                   dbEntry.Hour7GC = sec3.Hour7GC;
                   dbEntry.Hour8GC = sec3.Hour8GC;
                   dbEntry.PosiDonations = sec3.PosiDonations;
                   dbEntry.Notes = sec3.Notes;
               }
               db.SaveChanges();
           }
        }

        public Section3 DeleteSection3(int id)
        {
            var db = new CapstoneDbContext();
            var dbEntry = db.Section3s.Find(id);
            if (dbEntry != null)
            {
                db.Section3s.Remove(dbEntry);
                db.SaveChanges();
            }
            return dbEntry;
        }
    }
}
