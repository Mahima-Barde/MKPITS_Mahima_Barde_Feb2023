using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Weakly_typed_MVC.Models;

namespace Weakly_typed_MVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Form1(string name,int rollno,string subject)
        {
            ViewBag.Name = name;
            ViewBag.Rollno = rollno;
            ViewBag.Subject = subject;
            return View("Index");
        }
    }
}