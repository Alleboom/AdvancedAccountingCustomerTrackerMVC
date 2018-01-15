using AdvancedAccountingCustomerTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdvancedAccountingCustomerTracker.ViewModels
{
    /// <summary>
    /// Accountants, Customers and a Work Order for a view
    /// </summary>
    public class WorkOrderCustomerAccountantViewModel
    {

        public IEnumerable<Accountant>  Accountants { get; set; }

        public IEnumerable<Customer> Customers { get; set; }

        public WorkOrder WorkOrder { get; set; }
    }
}