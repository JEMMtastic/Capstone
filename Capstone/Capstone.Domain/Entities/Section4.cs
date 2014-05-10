using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Capstone.Domain.Entities
{
    public class Section4
    {
        [HiddenInput(DisplayValue = false)]
        public int Section4Id { get; set; }
    }
}
