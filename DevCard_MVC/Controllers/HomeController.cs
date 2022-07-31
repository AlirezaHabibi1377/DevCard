using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            var model = new Contact();
            return View(model);
        }


        //// this is Iform collection
        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    return Json(Ok());
        //}


        // this operation is relate to model binding **********
        [HttpPost]
        public JsonResult Contact(Contact form)
        {
            return Json(Ok());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
