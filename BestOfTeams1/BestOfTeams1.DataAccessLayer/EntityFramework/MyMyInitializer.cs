using BestOfTeams1.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOfTeams1.DataAccessLayer.EntityFramework
{
   public class MyMyInitializer:CreateDatabaseIfNotExists<BestOfTeamsContext>
    {
        protected override void Seed(BestOfTeamsContext context)
        {
            for (int i = 0; i < FakeData.NumberData.GetNumber(5,15); i++)
            {
                Buses buses = new Buses()
                {
                    bNumberPlate= $"{FakeData.NumberData.GetNumber(1,81)} {FakeData.TextData.GetAlphabetical(3).ToUpper()} {FakeData.NumberData.GetNumber(1000,9999)}",
                    bWay = $"{FakeData.NumberData.GetNumber(1, 500)}{FakeData.TextData.GetAlphabetical(2).ToUpper()}"


                };
                context.buses.Add(buses);
                for (int j = 0; j < FakeData.NumberData.GetNumber(5, 15); j++)
                {
                    Drivers drivers = new Drivers()
                    {
                        dName = FakeData.NameData.GetFirstName(),
                        dSurname = FakeData.NameData.GetSurname(),
                        dAge = FakeData.NumberData.GetNumber(20, 50)
                       
                    };
                    buses.Drivers.Add(drivers);
                }
               
            }
            context.SaveChanges();
          
        }
           
    }
}
