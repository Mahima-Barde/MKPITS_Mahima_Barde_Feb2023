using Microsoft.AspNetCore.Mvc;
using Radiobutton.Models;

namespace Radiobutton.Controllers
{
    public class RadiobuttonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(radio r)
        {
            int total = 0;
            ViewBag.Number1 = r.Number1;
            ViewBag.Number2 = r.Number2;
            if(r.Caltype=="add")
            {
                total = r.Number1 + r.Number2;
                ViewBag.add = total;
            }
            if (r.Caltype == "Sub")
            {
                total = r.Number1 - r.Number2;
                ViewBag.Sub = total;
            }
            if (r.Caltype == "mul")
            {
                total = r.Number1 * r.Number2;
                ViewBag.mul = total;
            }
            TempData["Number1"] = r.Number1;
            return Redirect("/Radiobutton/Redirect");
           //return View();

        }
        public IActionResult Redirect()
        {
            return View();
        }
    }
}
