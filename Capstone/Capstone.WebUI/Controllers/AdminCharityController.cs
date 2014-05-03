using Capstone.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capstone.WebUI.Controllers
{
    public class AdminCharityController : Controller
    {
        //
        // GET: /AdminCharity/

        public AdminCharityController()
        {
            CharityRepository charRepo = new CharityRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        /*public ActionResult AddCharity()
        {

        }

        public ActionResult UpdateCharity()
        {

        }

        public ActionResult DeleteCharity()
        {

        }*/
    }
}
