using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Apartment.App.Business.Abstract;
using Apartment.App.Business.Concrete;
using Apartment.App.Domain.Entities;
using Apartment.App.Web.Models;
using Apartment.App.Web.Models.InvoiceTypeModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Apartment.App.Web.Controllers
{
    public class InvoiceTypeController : Controller
    {
        private readonly IinvoiceTypeService invoiceTypeService;

        public InvoiceTypeController(IinvoiceTypeService invoiceTypeService)
        {
            this.invoiceTypeService = invoiceTypeService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var types = invoiceTypeService.getAllInvoiceTypes();
            var model = new List<InvoiceTypeViewModel>();
            foreach (var item in types)
            {
                model.Add(new InvoiceTypeViewModel
                {
                    Id = item.Id,
                    typeName = item.TypeName, 
                    typeUnit= item.TypeUnit
                });
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        } 

        [HttpPost]
        public IActionResult Add(InvoiceTypeViewModel model)
        {
            
            if (!ModelState.IsValid)
            {
                RedirectToAction("Index");
            }
            invoiceTypeService.Add(model.typeName,model.typeUnit);
            return RedirectToAction("Index");
        }
    }
}
