using System.Collections.Generic;
using System.Threading.Tasks;
using Apartment.App.Business.Abstract;
using Apartment.App.Business.Concrete;
using Apartment.App.Business.DTO;
using Apartment.App.Domain.Entities;
using Apartment.App.Domain.Entities.IdentityEntities;
using Apartment.App.Web.Enums;
using Apartment.App.Web.Models;
using Apartment.App.Web.Models.InvoiceModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Apartment.App.Web.Controllers
{
    public class InvoiceController : Controller
    {

        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<User> signInManager;
        private readonly IinvoiceService invoiceService;
        private User currentUser = null;
        public InvoiceController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, SignInManager<User> signInManager,IinvoiceService invoiceService)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
            this.invoiceService = invoiceService;
            currentUser = userManager.FindByNameAsync(signInManager.Context.User.Identity.Name).Result;
        }

        // overload edip ev id sine göre de faturaları getirebiliriz.
        public IActionResult Index()
        {
            if (currentUser!=null)
            {
                var model = new InvoiceViewModel();
                var invoices = new List<Invoice>();
                
                model.isUserAdmin = getCurrentUserRole() == Roles.Admin ? true : false;
                
                invoices = model.isUserAdmin ? invoiceService.GetAllInvocies() : invoiceService.GetAllUserInvoices(currentUser);

                foreach (var invoice in invoices)
                {
                    model.Invoices.Add(new InvoiceModel
                    { 
                        housingId = invoice.Housing.Id,
                        InvoiceOwnerTrIdentity= invoice.user.TrIdentityNumber,
                        InvoiceOwnerName = invoice.user.FirstName + " " +invoice.user.LastName,
                        housingAdress = invoice.Housing.BlockNumber + " " + invoice.Housing.FloorNumber + " " + invoice.Housing.ApartmentNumber,
                        invoiceType = new InvoiceTypeDto { Id = invoice.InvoiceType.Id, Name = invoice.InvoiceType.TypeName,Unit = invoice.InvoiceType.TypeUnit},
                        IsSpended = invoice.IsSpended,
                        TotalDay = invoice.TotalDay,
                        InvoiceAmountOfUse = invoice.InvoiceAmountOfUse,
                        InvoiceUnitPrice = invoice.InvoiceUnitPrice,
                        InvoicePrice = invoice.InvoicePrice,
                        CreatedDate = invoice.CreatedDate,
                        LastSpendDate = invoice.LastSpendDate,
                    });
                }
                return View(model);
            };
            return RedirectToAction("Index", "Home");
        }

        #region  Fatura ekleme
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        //[Authorize(Roles = "admin")]
        //[HttpPost]
        //public IActionResult Add()
        //{
        //    return View();
        //}
        #endregion

        #region Fatura güncelleme
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }
        //[Authorize(Roles = "admin")]
        //[HttpPost]
        //public IActionResult Update()
        //{
        //    return View();
        //}
        #endregion

        #region Fatura ödeme



        #endregion

        #region Metotlar

        public Roles getCurrentUserRole()
        {
            IList<string> roles = userManager.GetRolesAsync(currentUser).Result;
            if (roles.Contains(Roles.Admin.ToString()))
            {
                return Roles.Admin;
            } 
            return Roles.User;
            
        }
        #endregion
    }
}
