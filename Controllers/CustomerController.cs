using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspnetCoreMvcFull.Models;
using AspnetCoreMvcFull.Models.ViewModels;
using AspnetCoreMvcFull.Models.Entities;
using AspnetCoreMvcFull.Data;

namespace AspnetCoreMvcFull.Controllers;

public class CustomerController : Controller
{

    private readonly ApplicationContext _context;

    public CustomerController(ApplicationContext context)
    {
        _context = context;
    }
    public IActionResult CustomerType() => View();

    [HttpPost]
    public async Task<IActionResult> CustomerType(CutomerTypeModel model)
    {

        var NewType = new CustomerType()
        {
            Customtype = model.Customtype,
            CustomDescription = model.CustomDescription,
        };
        if (ModelState.IsValid)
        {
            _context.Add(NewType);
            await _context.SaveChangesAsync();
            return RedirectToAction("CustomerRig", "FormLayouts");
        }



        return View(model);

    }

    public IActionResult CustomerRig() => View();



    [HttpPost]
    public async Task<IActionResult> CustomerRig(CustomerRig model)
    {
        var NewCustomerRig = new CustomerRig()
        {
            Name =model. CustomerRigName,
            Phone =model. CustomerRigPhone,
            Address = model.CustomerRigAddress,
        };
        if (ModelState.IsValid)
        {
            _context.Add(NewCustomerRig);
            await _context.SaveChangesAsync();
            return RedirectToAction("AddCustomer", "Customer");
        }
        return View();
    }



}

