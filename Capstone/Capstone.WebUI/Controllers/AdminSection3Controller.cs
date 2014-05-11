using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Domain.Concrete;
using Capstone.Domain.Entities;

namespace Capstone.WebUI.Controllers
{
    public class AdminSection3Controller : Controller
    {

        Section3Repository sect3Repo;

        public AdminSection3Controller()
        {
            sect3Repo = new Section3Repository();
        }

        public ActionResult Index()
        {
            List<Section3> sect3s = sect3Repo.GetSection3s().ToList<Section3>();

            return View(sect3s);
        }

        public ActionResult Create()
        {
            return View("Edit", new Section3());
        }

        public ActionResult Edit(int sect3Id)
        {
            // Get the correct charity
            Section3 s3 = sect3Repo.GetSection3s().FirstOrDefault(s => s.Section3Id == sect3Id);

            return View(s3);
        }

        [HttpPost]
        public ActionResult Edit(Section3 sect3)
        {
            if (ModelState.IsValid)
            {
                // Save the changes to the partnership night 
                sect3Repo.UpdateSection3(sect3);
                TempData["message"] = string.Format("Section 3 for Partnership Night {0} has been saved", sect3.pNight.Date);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(sect3);
            }
        }

        public ActionResult Delete(int sect3Id)
        {
            Section3 deletedSect3 = sect3Repo.DeleteSection3(sect3Id);
            if (deletedSect3 != null)
            {
                TempData["message"] = string.Format("Section 3 for Partnership Night {0} was deleted",
                deletedSect3.pNight.Date);
            }
            return RedirectToAction("Index");
        }

    }
}
