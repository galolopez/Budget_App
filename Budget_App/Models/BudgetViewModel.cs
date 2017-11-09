using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Budget_App.Models
{
    public class BudgetViewModel
    {
        public IEnumerable<Budget> Budgets { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}