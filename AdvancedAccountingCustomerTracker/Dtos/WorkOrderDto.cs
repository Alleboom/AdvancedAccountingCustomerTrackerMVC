using AdvancedAccountingCustomerTracker.Models;
using System;

namespace AdvancedAccountingCustomerTracker.Dtos
{
    public class WorkOrderDto
    {
        public int Id { get; set; }

        public int AccountantId { get; set; }

        public int CustomerId { get; set; }

        public String Summary { get; set; }

        public String Description { get; set; }

        public Accountant Accountant { get; set; }

        public Customer Customer { get; set; }
    }
}