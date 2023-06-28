using Actionlink_Example.Models;
using Microsoft.AspNetCore.Mvc;

namespace Actionlink_Example.Controllers
{
    public class DropdownlistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Dropdown d)
        {
            var selectedValue = Models.selectedTeatype;
            ViewBag.TeaType=selectedValue.ToString();
            return View();
        }
    }
}
