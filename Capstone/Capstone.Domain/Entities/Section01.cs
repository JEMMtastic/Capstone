using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Domain.Entities
{
    public class Section01
    {
        public PartnershipNight PN { get; set; }
        public bool NewCharity { get; set; }
        public string Purpose { get; set; }
        public string Contact { get; set; }
        //address to come from charity data in pn
        //telephone # to come from charity data
        //fed tax id to come from charity data
        //bv store num to come from bvlocation attached to pn
        public int Wk1FourGc { get; set; }
        public int Wk1FiveGc { get; set; }
        public int Wk1SixGc { get; set; }
        public int Wk1SevenGc { get; set; }
        public int Wk1EightGc { get; set; }
        public int Wk2FourGc { get; set; }
        public int Wk2FiveGc { get; set; }
        public int Wk2SixGc { get; set; }
        public int WkSevenGc { get; set; }
        public int Wk2EightGc { get; set; }
        public int Wk3FourGc { get; set; }
        public int Wk3FiveGc { get; set; }
        public int Wk3SixGc { get; set; }
        public int Wk3SevenGc { get; set; }
        public int Wk3EightGc { get; set; }
        public decimal AvgChk4 { get; set; }
        public decimal AvgChk5 { get; set; }
        public decimal AvgChk6 { get; set; }
        public decimal AvgChk7 { get; set; }
        public decimal AVgChk8 { get; set; }
    }
}
