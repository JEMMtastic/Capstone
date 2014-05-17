using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Domain.Abstract;
using Capstone.Domain.Entities;

namespace Capstone.Domain.Concrete
{
    public class FormRepository : FormInterface
    {

        public void AddForm(Form sec3)
        {
            var db = new CapstoneDbContext();

            db.Forms.Add(sec3);
        }

        public Form GetFormById(int id)
        {
            var db = new CapstoneDbContext();

            return (from sec3 in db.Forms
                    where sec3.FormId == id
                    select sec3).FirstOrDefault();
        }

        public IQueryable<Entities.Form> GetForms()
        {
            var db = new CapstoneDbContext();

            return (from sec3 in db.Forms
                    select sec3).AsQueryable<Form>();
        }

        public void UpdateForm(Entities.Form sec3)
        {
           var db = new CapstoneDbContext();

           if (sec3.FormId == 0)
           {
               db.Forms.Add(sec3);
           }
           else
           {
               var dbEntry = db.Forms.Find(sec3.FormId);
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

        public Form DeleteForm(int id)
        {
            var db = new CapstoneDbContext();
            var dbEntry = db.Forms.Find(id);
            if (dbEntry != null)
            {
                db.Forms.Remove(dbEntry);
                db.SaveChanges();
            }
            return dbEntry;
        }
    }
}
