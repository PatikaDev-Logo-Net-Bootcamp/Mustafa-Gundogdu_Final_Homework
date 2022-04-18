using System.Collections.Generic;
using System.Linq;
using Apartment.App.Business.Abstract;
using Apartment.App.Business.DTO;
using Apartment.App.Domain.Entities;
using Apartment.App.Domain.Entities.IdentityEntities;
using Apartment.App.Web.Enums;
using Apartment.App.Web.Models.HousingViewModels;
using Apartment.App.Web.Models.HousingViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Apartment.App.Web.Controllers
{
    
    public class HousingController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<User> signInManager;
        private readonly IFloorService floorService;
        private readonly IHousingService housingService;
        private readonly IMapper mapper;
        private User currentUser = null;
        public HousingController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, SignInManager<User> signInManager,IFloorService floorService, IHousingService housingService ,IMapper mapper)
        {
            this.userManager = userManager;
            this.housingService = housingService;
            this.roleManager = roleManager;
            this.floorService = floorService;
            this.signInManager = signInManager;
            this.mapper = mapper;
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
                    Floor = mapper.Map<FloorDto>(floorService.GetById(housing.Floor.Id)) ,
                    ApartmentNumber = housing.ApartmentNumber,
                    ApartmentSizeInfo = housing.ApartmentSizeInfo,
                });
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Add(int floorId)
        {
            var lastHusingNumber = housingService.GetHousingCountByFloorId(floorId) + 1;
            var floor = floorService.GetById(floorId);
            var users = userManager.Users.ToList();
            var model = new HousingAddViewModel
            {
                Users = mapper.Map<List<UserDto>>(users),
                HousingHirerTcIdentityNumber = "",
                Housing = new HousingDto
                {
                    ApartmentNumber = lastHusingNumber,
                    ApartmentSizeInfo = "",
                    Floor = mapper.Map<FloorDto>(floorService.GetById(floorId)),
                }
            };
            return View(model);
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
