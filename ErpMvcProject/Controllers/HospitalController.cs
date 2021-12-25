using ErpMvcProject.BusinessLayer;
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
        public ActionResult HospitalUpdate()
        {

            return View();
        }
        public ActionResult HospitalDelete()
        {

            return View();
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
    }
}