using Assignmen_Validation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignmen_Validation.Controllers
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
        public IActionResult Index(Greater_number g)
        {
            string result = null;
           

                if (g.number1 > g.number2)
                {
                   
                    ViewBag.result = "number1 is greater than number2";
                    return View();
                }
                else
                {
                    
                    ViewBag.result = "number2 is greater than number1";
                    return View();
                }
           
        }
        public IActionResult Privacy()
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