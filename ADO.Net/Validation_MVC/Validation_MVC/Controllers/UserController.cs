using Microsoft.AspNetCore.Mvc;
using Validation_MVC.Models;

namespace Validation_MVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        public IActionResult UserView(Usermodel um)
        {
            if (ModelState.IsValid)
            {
                return View(um);
            }
            else
            {
               
                return View();
            }
        }

    }
}
