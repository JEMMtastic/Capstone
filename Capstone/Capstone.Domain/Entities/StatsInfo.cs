using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Domain.Entities
{
    public class StatsInfo
    {
        public int StatsInfoId { get; set; }
        public decimal TotalSales { get; set; }
        public decimal AmountOfTotalSalesToCharity { get; set; }
        public decimal CashDonations { get; set; }
        public int GuestCount { get; set; }
        public PartnershipNight partnershipNight { get; set; }
    }
}
