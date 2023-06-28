using Microsoft.AspNetCore.Mvc;

namespace Actionlink_Example.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
