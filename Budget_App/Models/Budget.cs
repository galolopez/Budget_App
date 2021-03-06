﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Budget_App.Models
{
    public class Budget
    {
        public Budget()
        {
            this.Items = new HashSet<Item>();
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int HouseholdId { get; set; }

        public virtual Household Household { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}