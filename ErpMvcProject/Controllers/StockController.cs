using ErpMvcProject.BusinessLayer;
using ErpMvcProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErpMvcProject.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
        Stockmanager sm;
        Numaralar num;
        public StockController()
        {
            sm = new Stockmanager();
            num = new Numaralar();
        }
        public ActionResult StockStatus()
        {
          List<StockStatus> list=sm.GetStockStatus().ToList();
            return View(list);
        }
        public ActionResult StockCreate()
        {

            List<SelectListItem> dist = (from s in sm.GetCurrent()
                                         select new SelectListItem()
                                         {

                                             Value = s.Id.ToString(),
                                             Text = s.cName

                                         }).ToList();
            List<SelectListItem> proCode = (from s in sm.GetProduct()
                                            select new SelectListItem()
                                            {

                                                Value = s.PCode,
                                                Text = s.PCode

                                            }).ToList();
            ViewBag.Dist = dist;
            TempData["Dist"] = dist;
            ViewBag.Pro = proCode;
            TempData["pro"] = proCode;
            return View();
        }
        [HttpPost]
        public ActionResult StockCreate(StockViewModel svm)
        {
            svm.stockEntryTop.GeneralNumber = num.StockGeneralNumber();
            
            svm.stockEntryLower.Barcode = svm.stockEntryLower.ProductCode + "/" + svm.stockEntryLower.Lot;
            sm.CreateStock(svm);
            return RedirectToAction("StockStatus", "Stock");
        }
        [HttpGet]
        public ActionResult StockDistribution(int SId)
        {
            StockStatus ss = sm.GetStockStatus().FirstOrDefault(x => x.Id == SId);
            return View(ss);
        }
        [HttpPost]
        public ActionResult StockDistribution(StockStatus stockStatus)
        {
            int top = stockStatus.ShelfCount + stockStatus.BranchCount + stockStatus.ConsigneeCount;
            if (top > stockStatus.StockCount)
            {
                ViewBag.error = "Out Of Stock";
                StockStatus ss = sm.GetStockStatus().FirstOrDefault(x => x.Id == stockStatus.Id);
                return View(ss);
            }
            else
            {
                sm.UpdateStatus(stockStatus);
                return RedirectToAction("StockStatus");
            }        
        }
        public ActionResult StockListUpdate()
        {
            List<StockEntryTop> list = sm.GetStockEntryTop().ToList();
            return View(list);
        }
        public ActionResult StockUpdate(string gm)
        {
           StockViewModel svm= sm.SVM(gm);
            List<SelectListItem> dist = (from s in sm.GetCurrent()
                                         select new SelectListItem()
                                         {

                                             Value = s.Id.ToString(),
                                             Text = s.cName

                                         }).ToList();
            List<SelectListItem> proCode = (from s in sm.GetProduct()
                                            select new SelectListItem()
                                            {
                                                Value = s.PCode,
                                                Text = s.PCode
                                            }).ToList();
            ViewBag.Dist = dist;
            TempData["Dist"] = dist;
            ViewBag.Pro = proCode;
            TempData["pro"] = proCode;
            return View(svm);
        }
        [HttpPost]
        public ActionResult StockUpdate(StockViewModel svm)
        {

            sm.SVMUpdate(svm);
            return RedirectToAction("StockListUpdate");
        }
    }
}