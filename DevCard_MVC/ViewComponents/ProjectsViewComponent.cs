using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1,"تاکسی", "درخواست تاکسی درون شهری", "snapp","project-1.jpg"),
                new Project(2,"زود فود", "درخواست غذا آنلاین", "zoodfood","project-2.jpg"),
                new Project(3,"مدارس", "سیستم مدیریت یکپارچه مدارس", "Mohammad","project-3.jpg"),
                new Project(4,"فضاپیما", "برنامه مدیریت فضا پیما ناسا", "NASA","project-4.jpg"),
            };
            return View("_Projects", projects);
        }
    }
}
