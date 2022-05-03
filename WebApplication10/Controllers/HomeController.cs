using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication10.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.name = "chhavi";
            ViewBag.name1 = "sonu";
            ViewBag.name2 = "Deepak";


            ViewData["name"] = "chhavi";
            ViewData["name1"] = "sonu";
            ViewData["name2"] = 12.3;


            TempData["num"] =14556;
            TempData["name1"] ="chhavi";
            TempData["name2"] ="deepak";



            return View();
        }
    }
}