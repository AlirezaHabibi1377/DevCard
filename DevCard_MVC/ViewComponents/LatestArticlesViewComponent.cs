using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {

            var artiles = new List<Article>()
            {
                new Article(1,"آموزش asp.net core mvc","کامل ترین پکیج آموزش به زبان فارسی است.","blog-post-thumb-card-3.jpg"),
                new Article(2,"آموزش python","کامل ترین پکیج آموزش به زبان فارسی است.","blog-post-thumb-card-4.jpg"),
                new Article(3,"آموزش javascript","کامل ترین پکیج آموزش به زبان فارسی است.","blog-post-thumb-card-5.jpg"),
                new Article(4,"آموزش Machine learning with R","کامل ترین پکیج آموزش به زبان فارسی است.","blog-post-thumb-card-6.jpg"),
            };

            return View("_Articles", artiles);
        }
    }
}
