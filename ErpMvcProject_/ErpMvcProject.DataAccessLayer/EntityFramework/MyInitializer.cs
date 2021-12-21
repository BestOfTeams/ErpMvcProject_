using ErpMvcProject.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.DataAccessLayer.EntityFramework
{
    public class MyInitializer : CreateDatabaseIfNotExists<ErpMvcContext>
    {

        
    
    //public class MyInitializer 
    //{
    //    public MyInitializer()
    //    {

        
       protected override void Seed(ErpMvcContext context)
        {
            base.Seed(context);
        }
    }
}
