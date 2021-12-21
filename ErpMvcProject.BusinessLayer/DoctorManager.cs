using ErpMvcProject.DataAccessLayer.EntityFramework;
using ErpMvcProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.BusinessLayer
{
  public  class DoctorManager
    {
        Repository<Current> rcur = new Repository<Current>();
        public List<Current> GetDoctors()
        {
            return rcur.List(x => x.CurrentGroupsId == 1);
        }
    }
}
