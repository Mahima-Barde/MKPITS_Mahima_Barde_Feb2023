using Student_list_MVC_Insert.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_list_MVC_Insert.Controllers
{
    public class HomeController : Controller
    {
        //GET :Item
        public ActionResult Index()
        {
            StudentDBhandler studentDBhandler = new StudentDBhandler();
            ModelState.Clear();
            return View(studentDBhandler.GetStudents());
        }

        // 2. *********** Add New Item ***********
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentModel student)
        {
            // try
            //{
            if (ModelState.IsValid)
            {
                StudentDBhandler ItemHandler = new StudentDBhandler();
                if (ItemHandler.insertValue(student))
                {
                    ViewBag.Message = "Item Added Successfully";
                    ModelState.Clear();
                }
            }
            return View();
        }

        //******************* Edit/Update the student information ***********
        [HttpGet]
        public ActionResult Edit(int roll_no)
        {
            StudentDBhandler handler = new StudentDBhandler();
            return View(handler.GetStudents().Find(StudentModel => StudentModel.roll_no == roll_no));
        }
        [HttpPost]
        public ActionResult Edit(int roll_no, StudentModel sm)
        {
            try
            {
                StudentDBhandler dBhandler = new StudentDBhandler();
                dBhandler.insertValue(sm);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }
        //************ delete a student information *****************

        [HttpGet]
        public ActionResult Delete(int roll_no)
        {
            StudentDBhandler handler = new StudentDBhandler();
            return View(handler.GetStudents().Find(StudentModel => StudentModel.roll_no == roll_no));

        }
        [HttpPost]
        public ActionResult Delete(int roll_no,StudentModel sm)
        {
            try
            {
                StudentDBhandler handler = new StudentDBhandler();
                handler.deleteValue(sm);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }
        [HttpGet]
        public ActionResult Details(int roll_no)
           
        {
            StudentDBhandler handler=new StudentDBhandler();
            return View(handler.GetStudents().Find(StudentModel=> StudentModel.roll_no==roll_no));

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