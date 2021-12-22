using ErpMvcProject.BusinessLayer;
using ErpMvcProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErpMvcProject.Controllers
{
     
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager();
        // GET: Product
        public ActionResult Product()
        {
           
            
            return View();
        }
        public ActionResult Update()
        {
           
            return View();
        }
        public ActionResult Delete()
        {
            
            return View();
        }
        public ActionResult Details()
        {          
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            Products pro = null;
            List<SelectListItem> item = (from s in pm.GetDist()
                                         select new SelectListItem()
                                         {
                                             Text = s.cName,
                                             Value = s.Id.ToString()

                                         }).ToList();
            //item.Find(x => x.Value == pro.cDispId.Id.ToString()).Selected = true;
            TempData["dist"] = item;
            ViewBag.distributors = item;
            ViewBag.Title = "Create";

            return View();
        }
        [HttpPost]
        public ActionResult Create(Products products)
        {
            ProductManager pm = new ProductManager();
            pm.EnterProduct(products);

            return RedirectToAction("Product", "Product");
        }


    }
}