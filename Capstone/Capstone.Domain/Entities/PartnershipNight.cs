using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Domain.Entities
{
    public class PartnershipNight
    {
        public int PartnershipNightId { get; set; }
        public DateTime Date { get; set; }
        public Charity Charity { get; set; } 
        public BvLocation BVLocation { get; set; }
        public int CheckRequestId { get; set; }
        public decimal AmountRaised { get; set; }
        public string Comments { get; set; }
        public bool CheckRequestFinished { get; set; }
        public bool BeforeTheEventFinished { get; set; }
        public bool AfterTheEventFinished { get; set; }
    }
}
