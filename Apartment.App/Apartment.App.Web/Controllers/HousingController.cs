using System.Collections.Generic;
using Apartment.App.Business.Abstract;
using Apartment.App.Business.DTO;
using Apartment.App.Domain.Entities;
using Apartment.App.Domain.Entities.IdentityEntities;
using Apartment.App.Web.Enums;
using Apartment.App.Web.Models.HousingViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Apartment.App.Web.Controllers
{
    
    public class HousingController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<User> signInManager;
        private readonly IHousingService housingService;
        private User currentUser = null;
        public HousingController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, SignInManager<User> signInManager, IHousingService housingService )
        {
            this.userManager = userManager;
            this.housingService = housingService;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
            currentUser = userManager.FindByNameAsync(signInManager.Context.User.Identity.Name).Result;
        }
        
        public IActionResult Index()
        {
            var model = new HousingViewModel();
            model.isUserAdmin = userManager.GetRolesAsync(currentUser).Result.Contains(Roles.Admin.ToString());
            var housings = new List<Housing>();
            housings = model.isUserAdmin ? housingService.GetAllHousing() : housingService.GetHousingsByUserId(currentUser.Id);
            foreach (var housing in housings)
            {
                model.HousingList.Add(new HousingDto
                {
                    Id = housing.Id,
                    IsEmpty = housing.IsEmpty,
                    IsHomeowner = housing.IsHomeowner,
                    BlokNumber = housing.BlockNumber,
                    FloorNumber = housing.FloorNumber,
                    ApartmentNumber = housing.ApartmentNumber,
                    ApartmentSizeInfo = housing.ApartmentSizeInfo,
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
        public IActionResult Update()
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
