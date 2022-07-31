using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace DevCard_MVC.Controllers
{
    public class TestController : Controller
    {
        //public FileResult Index()
        //{
        //    var fileByte = System.IO.File.ReadAllBytes("wwwroot/Text.txt");
        //    const string name = "FileTest";
        //    return File(fileByte, MediaTypeNames.Text.Plain, name);
        //}

        public JsonResult Index()
        {
            return Json(new
            {
                id=12,
                name="alireza",
                job="master student & promgrammer"

            });

        }
    }
}
