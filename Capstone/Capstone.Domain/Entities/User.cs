using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Capstone.Domain.Entities
{
    public class User
    {
        [HiddenInput(DisplayValue = false)]
        public int UserId { get; set; }
        public BvLocation BvLocation { get; set; }
        public string UserFName { get; set; }
        public string UserLName { get; set; }
        public string Password { get; set; }
        public int AccessLevel { get; set; }
        public string UserEmail { get; set; }
        public string PhoneNumber { get; set; }
    }
}
