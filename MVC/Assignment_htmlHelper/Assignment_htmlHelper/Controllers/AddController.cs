using Assignment_htmlHelper.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_htmlHelper.Controllers
{
    public class AddController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Addition a)
        {
            ViewBag.number1=a.number1;
            ViewBag.number2 = a.number2;
            ViewBag.result = a.number1 + a.number2;
            return View();
        }
        
    }
}
