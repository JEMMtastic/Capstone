using Capstone.Domain.Concrete;
using Capstone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capstone.WebUI.Controllers
{
    public class AdminLocController : Controller
    {
        //
        // GET: /AdminLoc/

        public ActionResult AdminLocIndex()
        {
            //need to get a list of all users
            var db = new CapstoneDbContext();
            List<BvLocation> locations = (from l in db.BvLocations
                                select l).ToList<BvLocation>();
            return View(locations);
        }

    }
}
