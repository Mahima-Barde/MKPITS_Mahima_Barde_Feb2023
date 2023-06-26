using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using Using_HTMLhelper_Form.Models;

namespace Using_HTMLhelper_Form.Controllers
{
    public class DisplaySalaryController : Controller
    {
        int salary = 10000;
        public IActionResult Index()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Index(TotalSalaryModel s)
        {
            ViewBag.name = s.name;
            ViewBag.Employeetype = s.Employeetype;
            
            if(s.Employeetype=="clerk" || s.Employeetype=="Clerk")
            {
                s.TotalSalary = salary + 5000;
                ViewBag.TotalSalary =s.TotalSalary;
            }
             else if(s.Employeetype=="Peon"||s.Employeetype=="peon")
            {
                s.TotalSalary = salary + 1000;
                ViewBag.TotalSalary= s.TotalSalary;   

            }
            else if(s.Employeetype=="Manager" || s.Employeetype=="Manager")
            {
                s.TotalSalary = salary + 10000;
                ViewBag.TotalSalary=s.TotalSalary;
            }
            return View();

        }

    }
}
