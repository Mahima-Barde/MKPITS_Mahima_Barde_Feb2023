using Productitem_dropdown_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Productitem_dropdown_mvc.Controllers
{
    public class ProductitemController : Controller
    {
        // GET: Country
        public ActionResult Index()

        {
            return View();
        }

        [HttpGet]
        public ActionResult Details()
        {
            bindCategory();
            return View();
        }

        public void bindCategory()
        {
            ProductModel1 modelDemo = new ProductModel1();
            var category = modelDemo.Categories.ToList();
            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem { Text = "--Select Category--", Value = "0" });

            foreach (var m in category)
            {

                li.Add(new SelectListItem { Text = m.categoryname, Value = m.categoryid.ToString() });
                ViewBag.category = li;

            }
        }

        public JsonResult getProduct(int id)
        {
            ProductModel1 modelDemo = new ProductModel1();
            var ddlProduct = modelDemo.Products.Where(x => x.categoryid == id).ToList();
            List<SelectListItem> liproducts = new List<SelectListItem>();

            liproducts.Add(new SelectListItem { Text = "--Select Products--", Value = "0" });
            if (ddlProduct != null)
            {

                foreach (var x in ddlProduct)
                {
                    liproducts.Add(new SelectListItem { Text = x.productName, Value = x.productid.ToString() });
                }
            }
            return Json(new SelectList(liproducts, "Value", "Text", JsonRequestBehavior.AllowGet));
        }

    }

}
