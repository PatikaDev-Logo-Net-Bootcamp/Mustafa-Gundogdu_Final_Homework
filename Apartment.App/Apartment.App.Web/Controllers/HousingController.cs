using Microsoft.AspNetCore.Mvc;

namespace Apartment.App.Web.Controllers
{
    public class HousingController : Controller
    {
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
