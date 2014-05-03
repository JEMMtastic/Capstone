using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Capstone.Domain.Entities
{
    public class StatsInfo
    {
        [HiddenInput(DisplayValue = false)]
        public int StatsInfoId { get; set; }

        [Required(ErrorMessage = "Please enter the total sales.")]
        public decimal TotalSales { get; set; }

        [Required(ErrorMessage = "Please enter the amount of total sales to charity.")]
        public decimal AmountOfTotalSalesToCharity { get; set; }

        [Required(ErrorMessage = "Please enter the cash donations.")]
        public decimal CashDonations { get; set; }

        [Required(ErrorMessage = "Please enter the guest count.")]
        public int GuestCount { get; set; }

        //removing this temporarily - something isn't working with migrations[Required(ErrorMessage = "Please enter the partnership night.")]
        public PartnershipNight partnershipNight { get; set; }
    }
}
