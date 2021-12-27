using ErpMvcProject.BusinessLayer;
using ErpMvcProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErpMvcProject.Controllers
{
    public class HospitalController : Controller
    {
        // GET: Hospital
        HospitalManager hm;
        Numaralar ccode;
        // Numaralar ccode= new Numaralar();
        public HospitalController()
        {
            hm = new HospitalManager();
            ccode = new Numaralar();
        }
        public ActionResult HospitalList()
        {
            return View();
        }
        public ActionResult HospitalUpdate(int hId)
        {
            Current c = hm.GetHospitals().FirstOrDefault(x => x.Id == hId);
            List<SelectListItem> item = (from s in hm.GetCities()
                                         select new SelectListItem()
                                         {

                                             Value = s.Id.ToString(),
                                             Text = s.City

                                         }).ToList();
            List<SelectListItem> itemenum = Enum.GetNames(typeof(Employees)).Select(s =>
             new SelectListItem()
             {

                 Value = s,
                 Text = s.Replace("_", " ")

             }
            ).ToList();


            TempData["Cities"] = item;
            ViewBag.city = item;
            TempData["DepTitle"] = itemenum;
            ViewBag.DepTitle = itemenum;
            
            return View(c);
        }
        [HttpPost]
        public ActionResult HospitalUpdate(Current current)
        {
            hm.UpdateHospital(current);
            return RedirectToAction("HospitalList");
        }
        public ActionResult HospitalDelete(int hId)
        {
            Current c = hm.GetHospitals().FirstOrDefault(x => x.Id == hId);
            hm.DeleteHospital(c);
            return RedirectToAction("HospitalList");
        }
        public ActionResult HospitalCreate()
        {

            List<SelectListItem> item = (from s in hm.GetCities()
                                         select new SelectListItem()
                                         {

                                             Value = s.Id.ToString(),
                                             Text = s.City

                                         }).ToList();
            List<SelectListItem> itemenum = Enum.GetNames(typeof(Employees)).Select(s =>
             new SelectListItem()
             {

                 Value = s,
                 Text = s.Replace("_", " ")

             }
            ).ToList();


            TempData["Cities"] = item;
            ViewBag.city = item;
            TempData["DepTitle"] = itemenum;
            ViewBag.DepTitle = itemenum;
            return View();
        }
        [HttpPost]
        public ActionResult HospitalCreate(Current cp)
        {
            cp.cCode = ccode.CCodeHospital();
            hm.CreateHospital(cp);
            return RedirectToAction("HospitalList");
        }
    }
}