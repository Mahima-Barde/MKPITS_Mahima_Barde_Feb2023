using Item_DatabaseConnection_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Item_DatabaseConnection_MVC.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        // 1. *********** Add New Item ***********
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ItemModel ilist)
        {
            if(ModelState.IsValid)
            {
                Itemdbhadler handler= new Itemdbhadler();
                if(handler.insertvalue(ilist))
                {
                    ViewBag.message = "record is inserted successfully";
                    ModelState.Clear();
                }

            }
            return View();
           
        }
    }
}
