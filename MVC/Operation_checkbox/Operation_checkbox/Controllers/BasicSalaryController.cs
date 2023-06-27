using Microsoft.AspNetCore.Mvc;
using Operation_checkbox.Models;

namespace Operation_checkbox.Controllers
{
    public class BasicSalaryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SalaryModel s)
        {
            double hra = 0.25;
            double da = 0.45;
            double ta= 0.15;
            ViewBag.Name=s.Name;
            double total = 0.0;
            ViewBag.Basicsalary=s.Basicsalary;

            if(s.HRA==true)
            {
                hra = s.Basicsalary*hra;
                ViewBag.HRA = hra;

            }
            if (s.DA == true)
            {
                da = s.Basicsalary * da;
                ViewBag.DA = da;

            }
            if (s.TA == true)
            {
                ta = s.Basicsalary * ta;
                ViewBag.TA = ta;

            }
            total=hra+da+ta;
            ViewBag.Totalsalary = total;
            return View();
        }
    }
}
