using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using MVC_Assignment.Models;

namespace MVC_Assignment.Controllers
{
    public class EmpSalaryController : Controller
    {
        // GET: EmpSalary
        public ActionResult Index ()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index (FormCollection f)
        {
            int id = Convert.ToInt16(f["id"]);
            string name = f["name"].ToString();
            string dept = f["dept"].ToString();
            int manager = Convert.ToInt16(f["manager"]);
            int b_salary = Convert.ToInt16(f["sal"]);

            StringBuilder str = data_string(id, name, dept, b_salary);
            ViewBag.display = str;
            //return Content(str.ToString());
            return View();

        }


        public ActionResult Index1 ()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index1 (int id,string name,int manager,string dept,int sal)
        {
            StringBuilder str = data_string(id, name, dept, sal);
            ViewBag.display = str;
            return View();
        }


        public ActionResult Index2 ()
        {
            calSal calc = new calSal();
            return View(calc);
        }
        [HttpPost]
        public ActionResult Index2 (calSal n)
        {
            ViewBag.name = n.name;
            ViewBag.basic = n.basic;
            ViewBag.da = n.daily_allowance;
            ViewBag.pf = n.provident_fund;
            ViewBag.hra = n.house_rent_allowance;
            ViewBag.netsal = n.net_sal;

            return View();
        }


        [HttpPost]
        public ContentResult calculateSal ()
        {
            int id = Convert.ToInt16(Request["id"]);
            string name = Request["name"].ToString();
            string dept = Request["dept"].ToString();
            int manager = Convert.ToInt16(Request["manager"]);
            int b_salary = Convert.ToInt16(Request["sal"]);

            StringBuilder str = data_string(id, name, dept, b_salary);
            return Content(str.ToString());
        }

        private static StringBuilder data_string (int id, string name, string dept, int b_salary)
        {
            StringBuilder str = new StringBuilder();
            str.Append($"<b>ID:</b>{id}<br/><b>Name:</b>{name}<br/><b>Dept:</b>{dept}<br/><b>Basic Salary:</b> {b_salary}<br/>");

            int da = 0, pf = 0, hra = 0, net_sal = 0;
            if (b_salary > 0)
            {
                if (b_salary > 8000)
                {
                    da = (int)(0.1 * b_salary);
                    pf = 2000;
                    hra = (int)(0.09 * b_salary);
                }
                else if (b_salary > 5000 && b_salary <= 8000)
                {
                    da = (int)(0.08 * b_salary);
                    pf = 1500;
                    hra = (int)(0.075 * b_salary);
                }
                else if (b_salary <= 5000)
                {
                    da = (int)(0.06 * b_salary);
                    pf = 1000;
                    hra = (int)(0.05 * b_salary);
                }
                net_sal = b_salary + da + hra - pf;
                str.Append($"<b>DA:</b>{da}<br/><b>HRA:</b>{hra}<br/><b>PF:</b>{pf}<br/><b>Net Salary:</b>{net_sal}<br/>");
            }

            return str;
        }
    }
}