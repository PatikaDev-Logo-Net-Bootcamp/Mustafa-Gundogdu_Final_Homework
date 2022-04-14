using Microsoft.AspNetCore.Mvc;

namespace Apartment.App.Web.Controllers
{
    public class HousingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
