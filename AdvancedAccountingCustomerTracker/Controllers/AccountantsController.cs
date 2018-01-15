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
    public class AccountantsController : Controller
    {

        ApplicationDbContext _context;

        public AccountantsController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var accountants = _context.Accountants;
            return View(accountants);
        }

        public ActionResult AccountantForm(int id = 0)
        {
            Accountant accountant;
            if(id == 0)
            {
                accountant = new Accountant();
            }
            else
            {
                accountant = _context.Accountants.Single(a => a.Id == id);
            }
            return View(accountant);
        }

        public ActionResult Save(AccountantDto AccountantDto)
        {
            if (AccountantDto.Id == 0)
            {
                var accountant = Mapper.Map<Accountant>(AccountantDto);
                _context.Accountants.Add(accountant);
            }
            else
            {
                var _accountant = _context.Accountants.Single(c => c.Id == AccountantDto.Id);
                Mapper.Map(AccountantDto, _accountant);
            }
            _context.SaveChanges();

            return Redirect("Index");
        }
    }
}