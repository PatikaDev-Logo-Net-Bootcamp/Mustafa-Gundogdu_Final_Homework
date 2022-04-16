using System.Collections.Generic;
using Apartment.App.Business.Abstract;
using Apartment.App.Domain.Entities.IdentityEntities;
using Apartment.App.Web.Models.HousingViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Apartment.App.Web.Controllers
{
    public class HousingController : Controller
    {
        private readonly IHousingService housingService;
        private readonly UserManager<User> userManager;
        public HousingController(IHousingService housingService, UserManager<User> userManager)
        {
            this.housingService = housingService;
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddHousing()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateHousing()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DeleteHousing()
        {
            return View();
        }
    }
}
