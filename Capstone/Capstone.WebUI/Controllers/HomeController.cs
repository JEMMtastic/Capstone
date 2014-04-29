using Capstone.Domain.Concrete;
using Capstone.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Domain.Entities;

namespace Capstone.WebUI.Controllers
{
    public class HomeController : Controller
    {
        PartnershipNightInterface pnRepo;
        UserInterface uRepo;
        CharityInterface cRepo;
        BvLocationInterface lRepo;
        StatsInfoInterface sRepo;

        // The default constructor is called by the framework
        public HomeController()
        {
            uRepo = new UserRepository();
            pnRepo = new PartnershipNightRepository();
            cRepo = new CharityRepository();
            lRepo = new BvLocationRepository();
            sRepo = new StatsInfoRepository();

        }

        // Use this for dependency injection
        public HomeController(UserInterface iUser, PartnershipNightInterface iPn, CharityInterface iChar, BvLocationInterface iLoc, StatsInfoInterface iStats)
        {
            uRepo = iUser;
            pnRepo = iPn;
            cRepo = iChar;
            lRepo = iLoc;
            sRepo = iStats;
        }

        public ActionResult Index()
        {
            //data to get db up and running -- delete when done
            //add a location
            BvLocation loc1 = new BvLocation { Address = "333 N Main St", City = "BobVille", BvStoreNum = "BV99", Phone = "839-839-8393", Zip = "88898" };
            lRepo.AddBvLocation(loc1);
            //add a user
            User u1 = new User { UserFName = "Bob", UserLName = "Bobberson", AccessLevel = 1, BvLocation = loc1, Password = "bobshere", UserEmail = "bob@bob.com", PhoneNumber = "541-389-8293" };
            uRepo.AddUser(u1);
            //add a charity
            Charity c1 = new Charity { Address = "8939 S Seventh", City = "CharityVille", FederalTaxId = "893018XS", Name = "HopeForBob", Phone = "893-829-8393", TypeOfCharity = "Helpful", Zip = "83928" };
            cRepo.AddCharity(c1);
            //add a partnership night
            PartnershipNight pn1 = new PartnershipNight { AfterTheEventFinished = false, AmountRaised = 0, BeforeTheEventFinished = true, BVLocation = loc1, Charity = c1, CheckRequestFinished = false, Comments = "blah blah", Date = DateTime.Parse("05/30/2014") };
            pnRepo.AddPartnershipNight(pn1);
            //add stats
            StatsInfo s1 = new StatsInfo { AmountOfTotalSalesToCharity = 25.88M, CashDonations = 19.83M, GuestCount = 10, TotalSales = 100.00M, partnershipNight = pn1};
            sRepo.AddStatsInfo(s1);
            return View();
        }

    }
}
