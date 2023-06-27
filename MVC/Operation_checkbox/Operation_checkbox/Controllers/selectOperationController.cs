using Microsoft.AspNetCore.Mvc;
using Operation_checkbox.Models;

namespace Operation_checkbox.Controllers
{
    public class selectOperationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Operation o)
        {
            ViewBag.number1=o.number1;
            ViewBag.number2=o.number2;
            int result1 = 0;
            int result2 = 0;
            int result3 = 0;
            if (o.add == true)
            result1 =o.number1 +o.number2;
            ViewBag.add = result1;

            if (o.sub == true)
                result2 = o.number1 - o.number2;
            ViewBag.sub = result2;

            if (o.mul == true)
                result3 = o.number1 * o.number2;
            ViewBag.mul = result3;
            return View();
        }
    }
}
