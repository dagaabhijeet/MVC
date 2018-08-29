using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_GiftShop.Controllers
{
    public class GiftShopController : Controller
    {
        // GET: GiftShop
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }
    }
}