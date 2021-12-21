using ErpMvcProject.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.BusinessLayer
{
    public class Business
    {
        public Business()
        {
            ErpMvcContext db = new ErpMvcContext();
            db.currents.ToList();
        }
    }
}
