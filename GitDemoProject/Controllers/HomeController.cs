using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitDemoProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Initial commit
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
