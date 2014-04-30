using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Domain.Abstract;
using Capstone.Domain.Concrete;
using Capstone.Domain.Entities;

namespace Capstone.WebUI.Controllers
{
    public class AdminUserController : Controller
    { 
        public ActionResult AdminUserIndex()
        {
            //need to get a list of all users
            var db = new CapstoneDbContext();
            List<User> users = (from u in db.Users
                                select u).ToList<User>();

               
            //TODO:  add functionality to get users by restaurant or city?
            return View(users);
        }

        public ActionResult AddUser()
        {
            return View();
        }

    }
}
