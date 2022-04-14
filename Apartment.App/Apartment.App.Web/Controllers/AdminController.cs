using Microsoft.AspNetCore.Mvc;

namespace Apartment.App.Web.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
