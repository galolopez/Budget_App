using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Budget_App.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Amount { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public float? RecAmount { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        public string Date { get; set; }
        public string Description { get; set; }
        public bool? Status { get; set; }
        public int AccountId { get; set; }
        public int CategoryId { get; set; }        

        public virtual Account Account { get; set; }
        public virtual Category Category { get; set; }
    }
}