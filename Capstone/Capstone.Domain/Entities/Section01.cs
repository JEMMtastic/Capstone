using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage="You must fill out all fields")]
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
    }
}
