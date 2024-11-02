using AspnetCoreMvcFull.Data;
using AspnetCoreMvcFull.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace AspnetCoreMvcFull.Controllers
{
    public class CustomerEditController : Controller
    {
        private readonly ApplicationContext _context;
        public CustomerEditController(ApplicationContext context)
        {
            _context = context;
        }
        // GET: Edit Customer Type
        public async Task<IActionResult> Edit(int id)
        {
            var customerType = await _context.customerTypes.FirstOrDefaultAsync(c => c.CustomerId == id);
            if (customerType == null)
            {
                return NotFound();
            }
            return View(customerType);
        }
        // POST: Update Customer Type
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(CustomerType customerType)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerTypeExists(customerType.CustomerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("CusType", "Tables"); // Redirect to the appropriate action
            }
            return View(customerType);
        }

        private bool CustomerTypeExists(int id)
        {
            return _context.customerTypes.Any(e => e.CustomerId == id);
        }


    }
}
