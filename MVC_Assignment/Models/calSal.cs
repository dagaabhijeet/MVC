using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Assignment.Models
{
    public class calSal
    {
        public int id { get; set; }
        public string name { get; set; }

        public int manager { get; set; }
        public int basic { get; set; }
        public string dept { get; set; }


        private int da;

        public int daily_allowance
        {
            get
            {
                if (basic > 8000)
                    da = (int)(0.1 * basic);
                else if (basic > 5000 && basic <= 8000)
                    da = (int)(0.08 * basic);
                else if (basic <= 5000)
                    da = (int)(0.06 * basic);

                return da;
            }
            set { da = value; }
        }

        private int hra;

        public int house_rent_allowance
        {
            get
            {
                if (basic > 8000)
                {
                    hra = (int)(0.09 * basic);
                }
                else if (basic > 5000 && basic <= 8000)
                {
                    hra = (int)(0.075 * basic);
                }
                else if (basic <= 5000)
                {
                    hra = (int)(0.05 * basic);
                }
                return hra;
            }
            set { hra = value; }
        }

        private int pf;

        public int provident_fund
        {
            get
            {
                if (basic > 8000)
                {
                    pf = 2000;
                }
                else if (basic > 5000 && basic <= 8000)
                {
                    pf = 1500;
                }
                else if (basic <= 5000)
                {
                    pf = 1000;
                }
                return pf;
            }
            set { pf = value; }
        }

        private int net_salary;

        public int net_sal
        {
            get
            {
                net_salary = basic + daily_allowance + house_rent_allowance - provident_fund;
                return net_salary;
            }
            set { net_salary = value; }
        }


    }
}