using AspnetCoreMvcFull.Data;
using Microsoft.AspNetCore.Mvc;
using AspnetCoreMvcFull.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using AspnetCoreMvcFull.Models;



namespace AspnetCoreMvcFull.Controllers
{
    public class AddCustomerController : Controller
    {
        private readonly ApplicationContext _context;

        public AddCustomerController(ApplicationContext context)
        {
            _context = context;
        }
        public IActionResult AddCustomer()
        {
            return View();
        }


        // POST: Handle form submission and add the new customer to the database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCustomer(AddCustomerModel customer)
        {
            if (ModelState.IsValid)
            {
                _context.AddCustomers.Add(customer);
                _context.SaveChanges();
                return RedirectToAction("CustomerList", "AddCustomer"); // Redirect to a suitable page, like an index or success page
            }

            return View("AddCustomer", "CustomerList"); // If validation fails, return to the form
        }
        // GET: Customer/List
        public async Task<IActionResult> CustomerList()
        {
            var customers = await _context.AddCustomers.ToListAsync();
            return View(customers);
        }

        
    }
    //Customer Delete
    

}

