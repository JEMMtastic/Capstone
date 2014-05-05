using Capstone.Domain.Concrete;
using Capstone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capstone.WebUI.Controllers
{
    public class AdminPartnershipNightController : Controller
    {
        //
        // GET: /AdminPartnershipNight/
        PartnershipNightRepository pnRepo;
        CharityRepository charRepo; 
        BvLocationRepository bvlocRepo;
        
        public AdminPartnershipNightController()
        {
            pnRepo = new PartnershipNightRepository();
            charRepo = new CharityRepository();
            bvlocRepo = new BvLocationRepository();
        }

        public ActionResult Index()
        {
            List<PartnershipNight> pnightEvents = pnRepo.GetPartnershipNights().ToList<PartnershipNight>();
            
            return View(pnightEvents);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int partnershipNightId)
        {
            PartnershipNight pnight = pnRepo.GetPartnershipNights().FirstOrDefault(pn => pn.PartnershipNightId == partnershipNightId);
            Session["charities"] = charRepo.GetCharities().ToList<Charity>();
            Session["bvlocations"] = bvlocRepo.GetBvLocations().ToList<BvLocation>(); 
            return View(pnight);
        }

        public ActionResult Delete()
        {
            return View();
        }

    }
}
