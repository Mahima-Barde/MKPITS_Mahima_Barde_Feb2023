using Assignment_htmlHelper.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_htmlHelper.Controllers
{
    public class OddandEven : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(EvenOdd e)
        {
            ViewBag.Number = e.Number;
            if(e.Number%2==0)
            {
                ViewBag.result = "Number is Even";
            }
            else
            {
                ViewBag.result = "Number is Odd";
            }
            return View();
        }
    }
}
