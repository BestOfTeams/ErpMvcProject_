using ErpMvcProject.BusinessLayer;
using ErpMvcProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErpMvcProject.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        CompanyManager cm;
        Numaralar ccode;
        // Numaralar ccode= new Numaralar();
        public CompanyController()
        {
            cm = new CompanyManager();
            ccode = new Numaralar();
        }
        public ActionResult CompanyList()
        {
            return View();
        }
        public ActionResult CompanyUpdate(int cId)
        {
          Current c=  cm.GetCompanies().FirstOrDefault(x=> x.Id==cId);
            List<SelectListItem> item = (from s in cm.GetCities()
                                         select new SelectListItem()
                                         {

                                             Value = s.Id.ToString(),
                                             Text = s.City

                                         }).ToList();
            List<SelectListItem> itemenum = Enum.GetNames(typeof(Company)).Select(s =>
             new SelectListItem()
             {

                 Value = ((int)(Enum.Parse(typeof(Company), s))).ToString(),
                 Text = s.Replace("_", " ")

             }
            ).ToList();
            List<SelectListItem> itemDep = Enum.GetNames(typeof(Employees)).Select(s =>
           new SelectListItem()
           {

               Value = s,
               Text = s.Replace("_", " ")

           }
          ).ToList();


            TempData["Cities"] = item;
            ViewBag.city = item;
            TempData["Dep"] = itemDep;
            ViewBag.dep = itemDep;
            TempData["CType"] = itemenum;
            ViewBag.CType = itemenum;
            return View(c);
        }
        [HttpPost]
        public ActionResult CompanyUpdate(Current current)
        {
            cm.UpdateCompany(current);
            return RedirectToAction("CompanyList", "Company");
        }
        public ActionResult CompanyDelete(int cId)
        {
            Current c = cm.GetCompanies().FirstOrDefault(x => x.Id == cId);
            cm.CompanyDeleted(c);
            return RedirectToAction("CompanyList", "Company");
        }
        public ActionResult CompanyCreate()
        {

            List<SelectListItem> item = (from s in cm.GetCities()
                                         select new SelectListItem()
                                         {

                                             Value = s.Id.ToString(),
                                             Text = s.City

                                         }).ToList();
            List<SelectListItem> itemenum = Enum.GetNames(typeof(Company)).Select(s =>
             new SelectListItem()
             {

                 Value = ((int)(Enum.Parse(typeof(Company), s))).ToString(),
                 Text = s.Replace("_", " ")

             }
            ).ToList();
            List<SelectListItem> itemDep = Enum.GetNames(typeof(Employees)).Select(s =>
           new SelectListItem()
           {

               Value = s,
               Text = s.Replace("_", " ")

           }
          ).ToList();


            TempData["Cities"] = item;
            ViewBag.city = item;
            TempData["Dep"] = itemDep;
            ViewBag.dep = itemDep;
            TempData["CType"] = itemenum;
            ViewBag.CType = itemenum;
            return View();
        }
        [HttpPost]
        public ActionResult CompanyCreate(Current cp)
        {
            cp.cCode = ccode.CCodeCompany();
            cm.CreateCompany(cp);           
            return RedirectToAction("CompanyList");
        }
    }
}