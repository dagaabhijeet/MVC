using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC2.Models;

namespace MVC2.Controllers
{
    public class SecondController : Controller
    {
        // GET: Second
        public ActionResult Index ()
        {
            //if (TempData["data"] != null)
            //{
            //    //string data = TempData["data"].ToString();
            //    //ViewBag.data = data;
            //}

            Employee e = new Employee();
            e.id = 100;
            e.name = "Abhishek";
            e.marks = 90;
            e.batchcode = "B006";
            ViewBag.emp = e;
            return View();
        }

        public ActionResult Index4 ()
        {
            List<Employee> emp_list = new List<Employee>();
            Employee e1 = new Employee();
            e1.id = 100;
            e1.name = "Sarthak";
            e1.batchcode = "B012";
            e1.marks = 80;

            emp_list.Add(e1);

            Employee e2 = new Employee { id = 101, name = "Paras", batchcode = "B011", marks = 59 };
            emp_list.Add(e2);
            Employee e3 = new Employee { id = 102, name = "Shivam", batchcode = "B101", marks = 68 };
            emp_list.Add(e3);


            ViewBag.list = emp_list;

            //return RedirectToAction("Index");
            return View();
        }

        public ActionResult Index5 ()
        {

            Employee e1 = new Employee();
            e1.id = 100;
            e1.name = "Sarthak";
            e1.batchcode = "B012";
            e1.marks = 80;
            return View(e1);
        }

        public ActionResult Index2 ()
        {
            List<Employee> emp_list = new List<Employee>() {
                new Employee() { id = 101, name = "Paras", batchcode = "B011", marks = 59 },
                 new Employee() { id = 102, name = "Shivam", batchcode = "B101", marks = 68 },
                  new Employee() { id = 103, name = "Shubham", batchcode = "B111", marks = 79 }
                };

            return View(emp_list);
        }

        public ActionResult Index3 ()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Index3 (FormCollection f)
        //{
        //    int n1 = Convert.ToInt16(f["n1"]);
        //    int n2 = Convert.ToInt16(f["n2"]);
        //    int res = n1 + n2;
        //    ViewBag.res = res;
        //    return View();
        //}

        [HttpPost]
        public ActionResult Index3 (int n1,int n2) // to transfer view's data to controller
            // NOTE: the parameter names should be same as the element name in html
        {
            int res = n1 + n2;
            ViewBag.res = res;
            return View();
        }

        [HttpPost]
        public ContentResult add ()
        {
            int n1 = Convert.ToInt16(Request["n1"]);
            int n2 = Convert.ToInt16(Request["n2"]);
            return Content((n1 + n2).ToString());
        }



        public ActionResult Index1 ()
        {
            Number_ex num = new Number_ex();
            return View(num);
        }
        [HttpPost]
        public ActionResult Index1 (Number_ex n)
        {
            ViewBag.res = (int)(n.n1 + n.n2);
            return View();
        }
    }
}