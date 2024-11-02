using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AspnetCoreMvcFull.Models.Entities;
using AspnetCoreMvcFull.Data;

namespace AspnetCoreMvcFull.Controllers
{
    public class DeleteCusController : Controller
    {
        private  ApplicationContext _context;

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            var customer = _context.AddCustomers.Find(id);  // Locate the customer by Id
            if (customer != null)
            {
                _context.AddCustomers.Remove(customer);  // Remove the customer from the database
                _context.SaveChanges();  // Save changes
            }
            return Ok();  // Return an HTTP 200 OK response
        }
    }
}
