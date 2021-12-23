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
        
        public ActionResult Update(int? pid)
        {
            Products pro = pm.GetProducts().FirstOrDefault(x => x.Id == pid) ;
            List<SelectListItem> item = (from s in pm.GetDist()
                                         select new SelectListItem()
                                         {

                                             Value = s.Id.ToString(),
                                             Text = s.cName
                                         }).ToList();
            TempData["dist"] = item;
            ViewBag.distributors = item;           
            return View(pro);
        }
        [HttpPost]
        public ActionResult Update(Products product,int? pid)
        {
            ProductManager pm = new ProductManager();
            product.cDispId = pm.GetDist().Where(x => x.Id == product.cDispId.Id).FirstOrDefault();
            Products p = pm.FindUpdate(pid);
            pm.UpdateProduct(product,pid);
            ViewBag.distributors =TempData["dist"];
            return RedirectToAction("Product", "Product",p);

        }
        public ActionResult Delete()
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
                                           
                                             Value = s.Id.ToString(),
                                             Text = s.cName

                                         }).ToList();
       
            TempData["dist"] = item;
            ViewBag.distributors = item;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Products products)
        {
            
            ProductManager pm = new ProductManager();
            var current = pm.GetDist().Where(x=>x.Id==products.cDispId.Id).FirstOrDefault();
            products.cDispId = current;
            pm.EnterProduct(products);
            return RedirectToAction("Product", "Product");
        }


    }
}