using ErpMvcProject.BusinessLayer;
using ErpMvcProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErpMvcProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        EmployeeManager em;
        Numaralar ccode;
        // Numaralar ccode= new Numaralar();
        public EmployeeController()
        {
            em = new EmployeeManager();
            ccode = new Numaralar();
        }
        public ActionResult EmployeeList()
        {
            return View();
        }
        public ActionResult EmployeeCreate()
        {

            List<SelectListItem> item = (from s in em.GetCities()
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
            TempData["EmployeeTitle"] = itemenum;
            ViewBag.EmployeeTitle = itemenum;
            return View();
        }
        [HttpPost]
        public ActionResult EmployeeCreate(Current current)
        {
            current.cCode = ccode.CCodeEmployee();
            em.CreateEmployee(current);
            return RedirectToAction("DoctorList", "Doctor");          
        }
        public ActionResult EmployeeUpdate(int eId)
        {
            Current c = em.GetEmployees().FirstOrDefault(x => x.Id == eId);
            List<SelectListItem> item = (from s in em.GetCities()
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
            TempData["EmployeeTitle"] = itemenum;
            ViewBag.EmployeeTitle = itemenum;
            return View(c);
        }
        [HttpPost]
        public ActionResult EmployeeUpdate(Current current)
        {
            em.UpdateEmployee(current);
            return RedirectToAction("EmployeeList", "Employee");
            
        }
        public ActionResult EmployeeDelete(int eId)
        {
            em.DeleteEmployee(eId);
            return RedirectToAction("EmployeeList", "Employee");
        }
       
    }
}