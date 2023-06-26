using Microsoft.AspNetCore.Mvc;
using Using_HTMLhelper_Form.Models;

namespace Using_HTMLhelper_Form.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Signup u)
        {
            ViewBag.username = u.username;
            ViewBag.password=u.password;
            return View();
        }
    }
}
