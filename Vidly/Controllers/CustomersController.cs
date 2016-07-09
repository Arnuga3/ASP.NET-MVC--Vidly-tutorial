using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index(int? id)
        {
        
            var customers = new List<Customer>
            {
                new Customer { Name = "John Smith" , Id = 1},
                new Customer { Name = "Mary Williams", Id = 2 }
            };

            if (id.HasValue)
            {
                foreach (var customer in customers)
                {
                    if (customer.Id == id)
                    {
                        return Content(customer.Name);
                    }
                }
            }

            var viewModel = new CustomerList
            {
                Customers = customers
            };

            return View(viewModel);
            
        }
    }
}