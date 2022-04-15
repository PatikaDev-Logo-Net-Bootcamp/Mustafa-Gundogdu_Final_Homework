using Microsoft.AspNetCore.Mvc;

namespace Apartment.App.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Users()
        {
            return RedirectToAction("Index", "Admin");
        }

        [HttpPost]
        public IActionResult AddUser()
        {
            return RedirectToAction("Index", "Admin");
        }

        [HttpPost]
        public IActionResult UpdateUser()
        {
            return RedirectToAction("Index", "Admin");
        }

        [HttpPost]
        public IActionResult DeleteUser()
        {
            return RedirectToAction("Index", "Admin");
        }
    }
}
