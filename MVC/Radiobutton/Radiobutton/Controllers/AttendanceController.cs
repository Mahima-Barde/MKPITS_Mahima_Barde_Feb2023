using Microsoft.AspNetCore.Mvc;
using Radiobutton.Models;
using System.Security.Cryptography.X509Certificates;

namespace Radiobutton.Controllers
{
    public class AttendanceController : Controller
    {
        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }
       
        static string present;
        static string absent;
        public IActionResult Index(Attendance a)
        {

            string s1, s2, s3, s4, s5, s6;
            if (a.stud1 = true)
            {
                present = "Shreya,";
            }
            else
            {
                absent = "Shreya,";
            }
            if (a.stud2 = true)
            {
                present = "Mahima";
            }
            else
            {
                absent = "Mahima,";
            }
            if (a.stud3 = true)
            {
                present = "Rupali,";
            }
            else
            {
                absent = "Rupali,";
            }
            ViewBag.Present = present;
            ViewBag.Absent = absent;
            return View();
        }
    }
}
