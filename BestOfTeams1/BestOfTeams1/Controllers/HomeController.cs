using BestOfTeams1.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BestOfTeams1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            test test = new test();
            // test.InsertBus();
            // test.UpdateBuses();
            //test.RemoveBus();

            // test.InsertDriver();
            // test.UpdateDriver();
            // test.RemoveDriver();
            return View();
        }
    }
}