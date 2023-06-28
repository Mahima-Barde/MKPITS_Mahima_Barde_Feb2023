using Actionlink_Example.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Actionlink_Example.Controllers
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

        public IActionResult Index(IFormCollection fc,UserModel u)
        {
            if (ModelState.IsValid)

            {
                u.name = fc["name"];


                return View(u);
            }
           else 
            { 
                return View(); 
            }
            

            
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
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