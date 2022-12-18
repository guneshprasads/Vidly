using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_2nd_try.Models;
using Vidly_2nd_try.ViewModels;

namespace Vidly_2nd_try.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public ActionResult New()
        {
            var memberlist = _context.MembershipTypes.ToList();
            var viewmodel = new NewCustomerViewModel()
            {
                Customer = new Customer(),
                MembershipTypes = memberlist
            };
            return View(viewmodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewmodel = new NewCustomerViewModel()
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };
                return View("New", viewmodel);
            }

            if (customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }
            else 
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.Dateofbirth = customer.Dateofbirth;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            }
            
            _context.SaveChanges();
            return RedirectToAction("Index","Customer");
        }

        public ActionResult Index() 
        {
            var customers = _context.Customers.Include(c=>c.MembershipType).ToList();
            return View(customers);
        }

        
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            return View(customer);
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            var viewModel = new NewCustomerViewModel()
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("New",viewModel);
        }
    }
}