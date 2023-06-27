using CheckBox_htmlhelper.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheckBox_htmlhelper.Controllers
{
    public class CheckboxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Checkbox c)
        {  
            ViewBag.Tea=c.Tea.ToString();
            ViewBag.Laundry=c.Laundry.ToString();
            ViewBag.Breakfast=c.Breakfast.ToString();
            return View();
        }
    }
}
