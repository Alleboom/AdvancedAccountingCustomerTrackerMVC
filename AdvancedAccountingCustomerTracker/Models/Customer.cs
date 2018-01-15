using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdvancedAccountingCustomerTracker.Models
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public String Name { get; set; }

        [Required]
        [StringLength (15)]
        public String PhoneNumber { get; set; }

    }
}