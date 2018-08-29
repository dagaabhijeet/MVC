using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            //return View("Contact123");
            return View("~/Views/Home/Contact.cshtml");
        }

        public string Products(string Category)
        {
            return "Category is " + Category;
        }
    }
}