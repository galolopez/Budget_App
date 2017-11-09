using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Budget_App.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int BudgetId { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Amount { get; set; }
        public string Name { get; set; }

        public virtual Category Category { get; set; }
        public virtual Budget Budget { get; set; }
    }
}