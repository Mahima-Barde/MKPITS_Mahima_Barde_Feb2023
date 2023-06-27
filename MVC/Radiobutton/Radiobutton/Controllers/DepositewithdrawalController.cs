using Microsoft.AspNetCore.Mvc;
using Radiobutton.Models;

namespace Radiobutton.Controllers
{
    public class DepositewithdrawalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(deposite d )
        {
            int Amount=0;
            int balance = 10000;
            ViewBag.name = d.name;
            Amount = d.amount;

            if(d.transaction=="deposite")
            {
                Amount = balance + Amount;
                ViewBag.amount = Amount;
            }
            else if (d.transaction == "withdrawal")
            {
                Amount = balance - Amount;
                ViewBag.amount = Amount;
            }

            return View();
        }
    }
}
