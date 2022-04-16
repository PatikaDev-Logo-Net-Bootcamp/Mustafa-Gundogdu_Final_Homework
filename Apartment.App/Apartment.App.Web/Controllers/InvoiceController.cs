using Microsoft.AspNetCore.Mvc;

namespace Apartment.App.Web.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        #region  Fatura ekleme
        //[HttpGet]
        //public IActionResult Add()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Add()
        //{
        //    return View();
        //}
        #endregion

        #region Fatura güncelleme
        //[HttpGet]
        //public IActionResult Update()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Update()
        //{
        //    return View();
        //}
        #endregion

        #region Fatura ödeme

        

        #endregion
    }
}
