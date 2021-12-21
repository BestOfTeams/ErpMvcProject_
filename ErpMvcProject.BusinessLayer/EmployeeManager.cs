using ErpMvcProject.DataAccessLayer.EntityFramework;
using ErpMvcProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.BusinessLayer
{
   public class EmployeeManager
    {
        Repository<Current> rcur = new Repository<Current>();
        public List<Current> GetEmployees()
        {
            return rcur.List(x => x.CurrentGroupsId == 2);
        }
    }
}
