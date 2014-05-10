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
            throw new NotImplementedException();
        }

        public IQueryable<Section4> Section4s
        {
            get { return db.Section4s; }
        }

        public void SaveSection4(Section4 s)
        {
            throw new NotImplementedException();
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
