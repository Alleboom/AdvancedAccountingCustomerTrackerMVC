using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdvancedAccountingCustomerTracker.Models
{
    public class WorkOrder
    {
        [Required]
        public int Id { get; set; }

        public int AccountantId { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(255)]
        public String Summary { get; set; }

        public String Description { get; set; }

        public Accountant Accountant { get; set; }

        [Required]
        public Customer Customer { get; set; }

    }
}