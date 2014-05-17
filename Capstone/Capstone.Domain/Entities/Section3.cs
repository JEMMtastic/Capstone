using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Capstone.Domain.Entities
{
    public class Section3
    {
        // Section 0 + 1
        public PartnershipNight PN { get; set; }
        public bool NewCharity { get; set; }
        public string Purpose { get; set; }
        public string Contact { get; set; }
        //address to come from charity data in pn
        //telephone # to come from charity data
        //fed tax id to come from charity data
        //bv store num to come from bvlocation attached to pn
        [Required(ErrorMessage = "You must fill out all fields")]
        public int Wk1FourGc { get; set; }
        [Required(ErrorMessage = "You must fill out all fields")]
        public int Wk1FiveGc { get; set; }
        [Required(ErrorMessage = "You must fill out all fields")]
        public int Wk1SixGc { get; set; }
        [Required(ErrorMessage = "You must fill out all fields")]
        public int Wk1SevenGc { get; set; }
        [Required(ErrorMessage = "You must fill out all fields")]
        public int Wk1EightGc { get; set; }
        [Required(ErrorMessage = "You must fill out all fields")]
        public int Wk2FourGc { get; set; }
        [Required(ErrorMessage = "You must fill out all fields")]
        public int Wk2FiveGc { get; set; }
        [Required(ErrorMessage = "You must fill out all fields")]
        public int Wk2SixGc { get; set; }
        [Required(ErrorMessage = "You must fill out all fields")]
        public int WkSevenGc { get; set; }
        [Required(ErrorMessage = "You must fill out all fields")]
        public int Wk2EightGc { get; set; }
        [Required(ErrorMessage = "You must fill out all fields")]
        public int Wk3FourGc { get; set; }
        [Required(ErrorMessage = "You must fill out all fields")]
        public int Wk3FiveGc { get; set; }
        [Required(ErrorMessage = "You must fill out all fields")]
        public int Wk3SixGc { get; set; }
        [Required(ErrorMessage = "You must fill out all fields")]
        public int Wk3SevenGc { get; set; }
        [Required(ErrorMessage = "You must fill out all fields")]
        public int Wk3EightGc { get; set; }
        [Required(ErrorMessage = "You must fill out all fields")]
        public decimal AvgChk4 { get; set; }
        [Required(ErrorMessage = "You must fill out all fields")]
        public decimal AvgChk5 { get; set; }
        [Required(ErrorMessage = "You must fill out all fields")]
        public decimal AvgChk6 { get; set; }
        [Required(ErrorMessage = "You must fill out all fields")]
        public decimal AvgChk7 { get; set; }
        [Required(ErrorMessage = "You must fill out all fields")]
        public decimal AVgChk8 { get; set; }

        // Section 3
        [HiddenInput(DisplayValue = false)]
        public int Section3Id {get; set;}

        //Foreign key for partnership night, so we can keep track of what these stats are for
        public PartnershipNight pNight { get; set; }

        [Required]
        public decimal Hour4Sales { get; set; }

        [Required]
        public decimal Hour5Sales { get; set; }

        [Required]
        public decimal Hour6Sales { get; set; }
        
        [Required]
        public decimal Hour7Sales { get; set; }

        [Required]
        public decimal Hour8Sales { get; set; }

        [Required]
        public int Hour4GC { get; set; }

        [Required]
        public int Hour5GC { get; set; }

        [Required]
        public int Hour6GC { get; set; }

        [Required]
        public int Hour7GC { get; set; }

        [Required]
        public int Hour8GC { get; set; }

        [Required]
        public decimal PosiDonations { get; set; } //entered by user

        [Required]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        //Calculation methods
        public decimal getTotalSales() 
        {
            return (Hour4Sales + Hour5Sales + Hour6Sales + Hour7Sales + Hour8Sales); //sum of all hours' sales for the event
        }

        public decimal getAvgCheck(decimal sales, int gc) 
        {
            return sales / gc;  //Divide the hour's sales by the guest count to get the average check amt. for the hour.
        }

        public decimal getDonation()
        {
            return getTotalSales() * 0.10M;
        }
    }
}
