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
    public class AdminStatsController : Controller
    {
        StatsInfoInterface repository;

        public AdminStatsController()
        {
            repository = new StatsInfoRepository();
        }

        public AdminStatsController(StatsInfoInterface repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            var db = new CapstoneDbContext();
            List<StatsInfo> stats = (from s in db.StatsInfos.Include("PartnershipNight")
                                        select s).ToList<StatsInfo>();
            return View(stats);
        }

        public ViewResult EditStats(int statsInfoId)
        {
            StatsInfo s = repository.StatsInfos
                .FirstOrDefault(i => i.StatsInfoId == statsInfoId);
            return View(s);
        }

        [HttpPost]
        public ActionResult EditStats(StatsInfo s)
        {
            if (ModelState.IsValid)
            {
                repository.SaveStatsInfo(s);
                TempData["message"] = string.Format("{0} has been saved", s.StatsInfoId);
                return RedirectToAction("AdminStatsIndex");
            }
            else
            {
                return View(s);
            }
        }

        public ViewResult CreateStats()
        {
            return View("EditStats", new StatsInfo());
        }

        [HttpPost]
        public ActionResult DeleteStats(int statsInfoId)
        {
            StatsInfo deletedStatsInfo = repository.DeleteStatsInfo(statsInfoId);
            if (deletedStatsInfo != null)
            {
                TempData["message"] = string.Format("{0} was deleted", deletedStatsInfo.StatsInfoId);
            }
            return RedirectToAction("Index");
        }
    }
}
