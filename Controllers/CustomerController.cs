using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_2nd_try.Models;

namespace Vidly_2nd_try.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        
        public ActionResult Index()
        {
            var customer = new List<Customer>
            {
                new Customer{ Id=1,Name = "Customer 1" },
                new Customer{ Id=2,Name = "Customer 2" },
                new Customer{ Id=3,Name = "Customer 3" }
            };
            return View(customer);
        }

        
        public ActionResult Details(int id)
        {
            if (id == 1)
            {
                var customer = new Customer() { Name = "Customer 1" };
                return View(customer);
            }
            if (id == 2)
            {
                var customer = new Customer() { Name = "Customer 2" };
                return View(customer);
            }
            if (id == 3)
            {
                var customer = new Customer() { Name = "Customer 3" };
                return View(customer);
            }
            return Content("Something went wrong");
        }
    }
}