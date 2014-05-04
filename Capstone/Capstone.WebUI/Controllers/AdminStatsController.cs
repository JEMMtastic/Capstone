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

        public ActionResult EditStats(int statsInfoId)
        {
            StatsInfo s = repository.GetStatsInfo(statsInfoId);
            return View(s);
        }
    }
}
