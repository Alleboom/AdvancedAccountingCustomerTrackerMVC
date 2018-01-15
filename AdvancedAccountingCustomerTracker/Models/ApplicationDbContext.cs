using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdvancedAccountingCustomerTracker.Models
{
    public class ApplicationDbContext : DbContext
    {


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Accountant> Accountants { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }



        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}