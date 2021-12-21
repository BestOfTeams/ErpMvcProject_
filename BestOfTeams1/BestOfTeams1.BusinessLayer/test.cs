using BestOfTeams1.DataAccessLayer.EntityFramework;
using BestOfTeams1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOfTeams1.BusinessLayer
{
   public class test
    {
        Repository<Buses> rBuses = new Repository<Buses>();
        Repository<Drivers> rDrivers = new Repository<Drivers>();
        public test()
        {
            BestOfTeamsContext db = new BestOfTeamsContext();
             db.buses.ToList();
            // var busBist = rBuses.List();
            // var wBusList = rBuses.List(x => x.Id == 4);

            //var DriverList = rDrivers.List();
            //var wDriverList = rDrivers.List(x => x.Id == 4);
        }
        public void InsertBus()
        {
            Drivers driver = rDrivers.Find(s => s.Id == 4);
            int result = rBuses.Insert(new Buses()
            {   
                bNumberPlate="34 bjk 1903",
                bWay="98s"
                
            });
               
        }
        public void UpdateBus()
        {
            Buses bus = rBuses.Find(x => x.Id == 5);
            if (bus!=null)
            {
                bus.bWay = "55ad";
                rBuses.Update(bus);
            }

        }
        public void RemoveBus()
        {
            Buses bus = rBuses.Find(x => x.Id == 10);
            rBuses.Remove(bus);
        }
        public void InsertDriver()
        {
            
            Buses bus = rBuses.Find(x => x.Id == 4);
            int result = rDrivers.Insert(new Drivers()
            {
                dName="Remzi",
                dSurname="Kavşak",
                dAge=49,
                Buses=bus,
                
            });

        }
        public void UpdateDriver()
        {

            Drivers drivers = rDrivers.Find(x => x.Id == 75);
            if (drivers != null)
            {
                drivers.dName = "Hakan";
                drivers.dSurname = "Taşıyan";
                rDrivers.Update(drivers);
            }

        }
        public void RemoveDriver()
        {
            Drivers drivers = rDrivers.Find(x => x.Id == 75);
            rDrivers.Remove(drivers);
        }

    }
}
