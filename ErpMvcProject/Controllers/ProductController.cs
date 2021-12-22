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
            //List<SelectList> a = (from s in Current
            //                      select new SelectListItem() {
            //                          Text=s.Cname
            //                      });

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