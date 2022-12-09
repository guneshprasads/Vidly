using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_2nd_try.Models;

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

        public ActionResult Index() 
        {
            var customers = _context.Customers.Include(c=>c.MembershipType).ToList();

            //var customer = new List<Customer>
            //{
            //    new Customer{ Id=1,Name = "Customer 1" },
            //    new Customer{ Id=2,Name = "Customer 2" },
            //    new Customer{ Id=3,Name = "Customer 3" }
            //};
            return View(customers);
        }

        
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            //if (id == 1)
            //{
            //    var customer = new Customer() { Name = "Customer 1" };
            //    return View(customer);
            //}
            //if (id == 2)
            //{
            //    var customer = new Customer() { Name = "Customer 2" };
            //    return View(customer);
            //}
            //if (id == 3)
            //{
            //    var customer = new Customer() { Name = "Customer 3" };
            //    return View(customer);
            //}
            return View(customer);
        }
    }
}