using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewDaata.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["New Message"] = "This is a new view Data";
            string[] upcomingmovies = { "adadasd", "adadasd", "adadasd", "adadasd"};
            string[] starcast = { "adadasd", "adadasd", "adadasd", "adadasd"};

            ViewBag.names = upcomingmovies;
            ViewBag.starcast = starcast ;
            return View();
        }
    }
}