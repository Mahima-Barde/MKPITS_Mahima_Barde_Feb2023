using CheckBox_htmlhelper.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CheckBox_htmlhelper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(userModel u)
        {
            if(u.Tea==true)
                ViewBag.Tea = "You have selected tea";
            if (u.Laundry == true)
                ViewBag.Laundry = "You have selected Laundry" ;
            if (u.Breakfast == true)
                ViewBag.Breakfast ="You have selected Breakfast";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}