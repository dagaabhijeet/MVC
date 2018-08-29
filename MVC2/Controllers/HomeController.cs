using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            ViewBag.Date = DateTime.Now.ToString();
            ViewData["name"] = "Aman";
            return View();
        }

        public string Index1()
        {
            return "Hello";
        }

        public ActionResult Index2()
        {
            int ch = 2;
            if (ch == 1)
                return View();
            else
                return Content("This is a content");
        }

        public ActionResult Index3()
        {
            TempData["data"] = "DATA";
            //return RedirectToAction("Index");
            return RedirectToAction("Index","Second");
        }


    }
}