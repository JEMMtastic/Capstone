using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Capstone.Domain.Entities
{
    public class Form
    {
        #region Section 0
        // "Name on check" - Comes from PartnershipNight.Charity.Name
        public string Purpose { get; set; }
        public string Contact { get; set; } // TODO: Add the contact to the partnership

        // "Organization mailing address" - Comes from PartnershipNight.Charity.Address, City, Zip, State (?)
        // "Telephone number" - Comes from PartnershipNight.Charity.Phone
        // "Federal tax I.D. number - PartnershipNight.Charity.FederalTaxId
        public bool NewPartner { get; set; }
        // "Hosting restaurant" - PartnershipNight.BvLocation.BvStoreNum
        // "Week day of Partnership" - PartnershipNight.Date
        // "Date of Partnership" - PartnershipNight.Date 
        #endregion
        
        #region Section 1
        public int Wk1Year { get; set; } // Prior Year Week X
        public int Wk2Year { get; set; }
        public int Wk3Year { get; set; }


        // Prior Year Adjusted Sales, week 1, Hour 4 thru 8 = Wk1HOURGc * LWkAvgChkHOUR
        // Prior Year Adjusted Sales Total = Sum of week 1 hours 4 thru 8

        // Prior Year Adjusted Sales, week 2, Hour 4 thr 8 = Wk1HOURGc * LWkAvgChkHOUR
        // Prior Year Adjusted Sales Total = Sum of week 2 hours 4 thru 8

        // Prior Year Adjusted Sales, week 3, Hour 4 thr 8 = Wk1HOURGc * LWkAvgChkHOUR
        // Prior Year Adjusted Sales Total = Sum of week 3 hours 4 thru 8

        public int Wk1FourGc { get; set; } // Week 1 Hours x-x Guest Count
        public int Wk1FiveGc { get; set; }
        public int Wk1SixGc { get; set; }
        public int Wk1SevenGc { get; set; }
        public int Wk1EightGc { get; set; }
        // "Guest Count week 1 total" - Add Wk1FourGc thru Wk1EightGc

        public int Wk2FourGc { get; set; } // Week 2 Hours x-x Guest Count
        public int Wk2FiveGc { get; set; }
        public int Wk2SixGc { get; set; }
        public int WkSevenGc { get; set; }
        public int Wk2EightGc { get; set; }
        // "Guest Count week 2 total" - Add Wk2FourGc thru Wk2EightGc

        public int Wk3FourGc { get; set; } // Week 3 Hours x-x Guest Count
        public int Wk3FiveGc { get; set; }
        public int Wk3SixGc { get; set; }
        public int Wk3SevenGc { get; set; }
        public int Wk3EightGc { get; set; }
        // "Guest Count week 3 total" - Add Wk3FourGc thru Wk3EightGc
        public decimal LWkAvgChkFour { get; set; } // Last week average check for hour X
        public decimal LWkAvgChkFive { get; set; }
        public decimal LWkAvgChkSix { get; set; }
        public decimal LWkAvgChkSeven { get; set; }
        public decimal LWkAvgChkEight { get; set; }


        // "Week 1 Adjusted Sales" - Sum of (Prior Year Adjusted Sales, week 1, Hour 4 thru 8 = Wk1HOURGc * LWkAvgChkHOUR) / 3
        // "Week 2 Adjusted Sales" - Sum of (Prior Year Adjusted Sales, week 2, Hour 4 thru 8 = Wk1HOURGc * LWkAvgChkHOUR) / 3
        // "Week 3 Adjusted Sales" - Sum of (Prior Year Adjusted Sales, week 3, Hour 4 thru 8 = Wk1HOURGc * LWkAvgChkHOUR) / 3
        // "Average Sales Total" - Sum of all weeks Adjsuted Sales

        // "Week 1 Average GC" - Sum of Wk1HOURGc / 3
        // "Week 2 Average GC" - Sum of Wk2HOURGc / 3
        // "Week 3 Average GC" - Sum of Wk3HOURGc / 3
        // "Average Guest Count Total" - Sum of all weeks Average Guest Count

        // "Overall Average Check" - Average Sales Total / Average Guest Count Total
        #endregion

        // Section 3
        [HiddenInput(DisplayValue = false)]
        public int FormId {get; set;}

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
