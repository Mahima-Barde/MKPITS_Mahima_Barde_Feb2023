using ItemDetails_Insert_List.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;

namespace ItemDetails_Insert_List.Controllers
{
    public class HomeController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            ViewBag.ItemList = "Computer Shop Item List Page";
            ItemDBhandler IHandler = new ItemDBhandler();
            ModelState.Clear();
            return View(IHandler.GetItems());
        }

        // 2. *********** Add New Item ***********
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ItemModel iList)
        {
            // try
            //{
            if (ModelState.IsValid)
            {
                ItemDBhandler ItemHandler = new ItemDBhandler();
                if (ItemHandler.insertvalue(iList))
                {
                    ViewBag.Message = "Item Added Successfully";
                    ModelState.Clear();
                }
            }
            return View();
        }

        // 1****************Edit****************

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ItemDBhandler dBhandler = new ItemDBhandler();
            return View(dBhandler.GetItems().Find(ItemModel => ItemModel.ID == id));
        }
        [HttpPost]
        public ActionResult Edit(int id, ItemModel ilist)
        {
            try {
                ItemDBhandler dBhandler = new ItemDBhandler();
                dBhandler.updatevalue(ilist);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
         }

        //3****************Delete**************

        [HttpGet]
        public ActionResult Delete(int id)
        {
            ItemDBhandler handler=new ItemDBhandler();
          
            return View(handler.GetItems().Find(ItemModel => ItemModel.ID == id));

        }
        [HttpPost]
        public ActionResult Delete(int id, ItemModel ilist)
        {
            try
            {
                ItemDBhandler dBhandler = new ItemDBhandler();
                dBhandler.deletevalue(ilist);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            }
        //4.**************Details*****************
        
        [HttpGet]
        public ActionResult Details(int id,ItemModel ilist)
        {
            ItemDBhandler dBhandler = new ItemDBhandler();
            return View(dBhandler.GetItems().Find(ItemModel => ItemModel.ID == id));
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