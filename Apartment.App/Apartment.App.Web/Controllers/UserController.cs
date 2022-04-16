using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apartment.App.Business.DTO;
using Apartment.App.Domain.Entities.IdentityEntities;
using Apartment.App.Web.Models.UserViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace Apartment.App.Web.Controllers
{
    public class UserController : Controller
    {



        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UserController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var allUsers = userManager.Users.ToList();
            var model = new UserViewModel();
            
            foreach (var user in allUsers)
            {
                 bool IsRoleUser = userManager.IsInRoleAsync(user, "user").Result;
                 if (IsRoleUser || true)
                 {
                    model.Users.Add(new UserDto
                    {
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Email = user.Email,
                        PhoneNumber = user.PhoneNumber,
                        TrIdentityNumber = user.TrIdentityNumber,
                        HasCar = user.HasCar,
                        CarPlateNumber = user.CarPlateNumber
                    });
                }   
            }
            return View(model);
        }
        

        #region User Adding 

        [HttpGet]
        public IActionResult Add( )
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(UserAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                userManager.CreateAsync(new User
                {
                    FirstName = model.User.FirstName,
                    LastName = model.User.LastName,
                    Email = model.User.Email,
                    PhoneNumber = model.User.PhoneNumber,
                    TrIdentityNumber = model.User.TrIdentityNumber,
                    HasCar = model.User.HasCar,
                    CarPlateNumber = model.User.CarPlateNumber,
                    
                }).Wait();
                
                return RedirectToAction("Index");
            }
            return View();
        }
        #endregion

        #region User Updating

         [HttpGet]
        public IActionResult Update(string TrIdentityNumber)
        {
            var user = userManager.Users.Where(u => u.TrIdentityNumber == TrIdentityNumber).First();
            var model = new UserUpdateViewModel();
            model.user = new UserDto
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                TrIdentityNumber = user.TrIdentityNumber,
                HasCar = user.HasCar,
                CarPlateNumber = user.CarPlateNumber,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(UserDto model)
        {
            if (ModelState.IsValid)
            {
                var user = userManager.Users.Where(u => u.TrIdentityNumber == model.TrIdentityNumber).First();
                user.CarPlateNumber = model.CarPlateNumber;
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.HasCar = model.HasCar;
                user.Email = model.Email;
                user.PhoneNumber = model.PhoneNumber;
                //update
                userManager.UpdateAsync(user);
                return RedirectToAction("Index", "User");
            }
            return View();
        }

        #endregion
       
    }
}
