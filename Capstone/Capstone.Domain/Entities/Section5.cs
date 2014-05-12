using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Capstone.Domain.Entities
{
    public class Section5
    {
        [HiddenInput(DisplayValue = false)]
        public int Section5Id { get; set; }

        // Foreign key for partnership night, so we can keep track of what these stats are for
        public PartnershipNight pNight { get; set; }
    }
}
