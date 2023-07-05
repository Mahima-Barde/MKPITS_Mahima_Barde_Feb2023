using Employee_details_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee_details_MVC.Controllers
{
    public class HomeController : Controller
    {
      
        public ActionResult index(int id) 
        {
            EmployeeDBhandler DBhandler = new EmployeeDBhandler();
            ModelState.Clear();
            return View(DBhandler.GetEmployees());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Create(EmployeeModel em)
        {
            if(ModelState.IsValid)
            {
                EmployeeDBhandler dBhandler= new EmployeeDBhandler();
                if(dBhandler.insertEmployee(em))
                {
                    ModelState.Clear();
                }
            }
            return View();
        }
            public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}