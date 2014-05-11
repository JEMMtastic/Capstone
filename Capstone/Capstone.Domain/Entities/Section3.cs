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
