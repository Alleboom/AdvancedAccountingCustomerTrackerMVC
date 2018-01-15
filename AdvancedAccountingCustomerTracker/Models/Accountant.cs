using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdvancedAccountingCustomerTracker.Models
{
    public class Accountant
    {

        [Required]
        public int Id { get; set; }
        
        [Required]
        public String Name { get; set; }

    }
}