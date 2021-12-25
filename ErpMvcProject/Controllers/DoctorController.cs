using ErpMvcProject.BusinessLayer;
using ErpMvcProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErpMvcProject.Controllers
{
    public class DoctorController : Controller
    {
        DoctorManager dm;
        Numaralar ccode;
        // Numaralar ccode= new Numaralar();
        public DoctorController()
        {
            dm = new DoctorManager();
            ccode = new Numaralar();
        }
        // GET: Doctor
        public ActionResult DoctorList()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DoctorCreate()
        {
            List<SelectListItem> item = (from s in dm.GetCities()
                                         select new SelectListItem()
                                         {

                                             Value = s.Id.ToString(),
                                             Text = s.City

                                         }).ToList();
            List<SelectListItem> itemenum = Enum.GetNames(typeof(enumDoctors)).Select(s =>
             new SelectListItem()
             {

                 Value = s,
                 Text = s.Replace("_", " ")

             }
            ).ToList();


            TempData["Cities"] = item;
            ViewBag.city = item;
            TempData["DoctorTitle"] = itemenum;
            ViewBag.DoctorTitle = itemenum;
            return View();
        }
        [HttpPost]
        public ActionResult DoctorCreate(Current current)
        {
            current.cCode = ccode.CCodeDoctor();
            dm.CreateDoctor(current);
            return RedirectToAction("DoctorList", "Doctor");
        }
        [HttpGet]
        public ActionResult DoctorUpdate(int dId)
        {
            Current c = dm.GetDoctors().FirstOrDefault(x => x.Id == dId);
            List<SelectListItem> item = (from s in dm.GetCities()
                                         select new SelectListItem()
                                         {

                                             Value = s.Id.ToString(),
                                             Text = s.City

                                         }).ToList();
            List<SelectListItem> itemenum = Enum.GetNames(typeof(enumDoctors)).Select(s =>
             new SelectListItem()
             {

                 Value = s,
                 Text = s.Replace("_", " ")

             }
            ).ToList();


            TempData["Cities"] = item;
            ViewBag.city = item;
            TempData["DoctorTitle"] = itemenum;
            ViewBag.DoctorTitle = itemenum;
            return View(c);
        }
        [HttpPost]
        public ActionResult DoctorUpdate(Current current)
        {
          
            dm.UpdateDoctor(current);
            return RedirectToAction("DoctorList", "Doctor");
        }
        public ActionResult DoctorDelete(int dId)
        {
            dm.DeleteDoctor(dId);
            return RedirectToAction("DoctorList","Doctor");
        }
      
      


    }
}