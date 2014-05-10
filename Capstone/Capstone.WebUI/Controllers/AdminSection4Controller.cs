using Capstone.Domain.Abstract;
using Capstone.Domain.Concrete;
using Capstone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capstone.WebUI.Controllers
{
    public class AdminSection4Controller : Controller
    {
        Section4Interface repository;

        public AdminSection4Controller()
        {
            repository = new Section4Repository();
        }

        public AdminSection4Controller(Section4Interface repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            var db = new CapstoneDbContext();
            List<Section4> section4 = (from s in db.Section4s
                                        select s).ToList<Section4>();
            return View(section4);
        }

        public ViewResult EditSection4(int section4Id)
        {
            Section4 s = repository.Section4s
                .FirstOrDefault(i => i.Section4Id == section4Id);
            return View(s);
        }

        [HttpPost]
        public ActionResult EditSection4(Section4 s)
        {
            if (ModelState.IsValid)
            {
                repository.SaveSection4(s);
                TempData["message"] = string.Format("{0} has been saved", s.Section4Id);
                return RedirectToAction("AdminSection4Index");
            }
            else
            {
                return View(s);
            }
        }

        public ViewResult CreateSection4s()
        {
            return View("EditSection4s", new Section4());
        }

        [HttpPost]
        public ActionResult DeleteSection4s(int section4Id)
        {
            Section4 deletedSection4 = repository.DeleteSection4(section4Id);
            if (deletedSection4 != null)
            {
                TempData["message"] = string.Format("{0} was deleted", deletedSection4.Section4Id);
            }
            return RedirectToAction("Index");
        }
    }
}
