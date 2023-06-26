using Microsoft.AspNetCore.Mvc;
using Using_HTMLhelper_Form.Models;

namespace Using_HTMLhelper_Form.Controllers
{
    public class OperationOnNumberController : Controller
    {
        int op;
        int Reesults;
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Operation o) 
        {
            ViewBag.number1 = o.number1;
            ViewBag.number2 = o.number2;
            ViewBag.operation=o.operation;
            switch(o.operation)
            {
                case "-":
                 o.number1= o.number1 - o.number2;
                    ViewBag.operation =o.number1;
                    break;
                case "+":
                    o.number1 = o.number1 + o.number2;
                    ViewBag.operation = o.number1;
                    break;
                case "/":
                    o.number1 =o.number1/o.number2;
                    ViewBag.operation = o.number1;
                    break;
                default:
                   o.number1 =o.number1*o.number2;
                    ViewBag.operation = o.number1;
                    break;
            }
            return View();
        }
    }
}
