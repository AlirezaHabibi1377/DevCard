using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new List<Service>
        {
            new Service(1,"طلایی"),
            new Service(2,"نقره ای"),
            new Service(3,"پلاتین"),
            new Service(4,"الماسی"),
        };


        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            
            var model = new Contact()
            {
                Services = new SelectList(_services, "Id","Name")
            };
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
        public IActionResult Contact(Contact model)
        {
            model.Services = new SelectList(_services, "Id", "Name");
            //if(ModelState.IsValid = false){}
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نیست. لطفا دوباره تلاش کنید.";
                return View(model);
            }

            model = new Contact
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            ModelState.Clear();
            ViewBag.success = "پیغام شما با موفقیت ارسال شد. با تشکر";
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
