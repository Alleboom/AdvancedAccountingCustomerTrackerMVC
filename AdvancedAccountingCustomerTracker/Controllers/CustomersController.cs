using AdvancedAccountingCustomerTracker.App_Start;
using AdvancedAccountingCustomerTracker.Dtos;
using AdvancedAccountingCustomerTracker.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdvancedAccountingCustomerTracker.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {

            var customers = _context.Customers;

            return View(customers);
        }

        /// <summary>
        /// GET /Customers/CustomerForm/{id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult CustomerForm(int id = 0)
        {

            Customer customer;
            if (id == 0)
            {
                customer = new Customer();
            }
            else
            {
                customer = _context.Customers.Single(c => c.Id == id);
            }
            return View(customer);
        }

        public ActionResult Save(CustomerDto CustomerDto)
        {
            if (CustomerDto.Id == 0)
            {
                var customer = Mapper.Map<Customer>(CustomerDto);
                _context.Customers.Add(customer);
            }
            else
            {
                var _customer = _context.Customers.Single(c => c.Id == CustomerDto.Id);
                Mapper.Map(CustomerDto, _customer);
            }
            _context.SaveChanges();

            return Redirect("Index");
        }
    }
}