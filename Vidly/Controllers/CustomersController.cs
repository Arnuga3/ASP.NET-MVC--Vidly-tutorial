using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        //db object
        private ApplicationDbContext _context;

        //Constructor
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        //Override the dispose methode, properly dispose the db object
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            //Include an additional related data from db using include()
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        [Route("Customers/Details/{id}")]

        public ActionResult Details(int? id)
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            foreach (var customer in customers)
            {
                if (customer.Id == id)
                {
                    return View(customer);
                }
            }

            return Content("Not found.");
        }
    }
}