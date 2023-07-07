using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Validation_MVC.Models;

namespace Validation_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
      

        public IActionResult studentdetail(StudentModel sm)
        {
            if(string.IsNullOrEmpty(sm.name))
            {
                ModelState.AddModelError("name", "Name Required");
            }
            if(sm.age==0 && sm.age>120 )
            {
                ModelState.AddModelError("age", "age is not valid");
            }
            if (ModelState.IsValid)
            {
                ViewBag.name = sm.name;
                ViewBag.age = sm.age;
                return View("Index");
            }
            else
            {
                ViewBag.name = "No Data";
                ViewBag.age = "No Data";
                return View("Index");
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