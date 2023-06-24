using Microsoft.AspNetCore.Mvc;
using MVC2_Template_WebApplication1.Models;
using System.Diagnostics;

namespace MVC2_Template_WebApplication1.Controllers
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

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Store()
        {
            return View();
        }
        public IActionResult Features()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}