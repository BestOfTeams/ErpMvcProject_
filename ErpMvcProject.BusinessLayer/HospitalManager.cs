﻿using ErpMvcProject.DataAccessLayer.EntityFramework;
using ErpMvcProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.BusinessLayer
{
   public class HospitalManager
    {
        Repository<Current> rcur = new Repository<Current>();
        Repository<Cities> rcity = new Repository<Cities>();
        public List<Current> GetHospitals()
        {
            return rcur.List(x => x.CurrentGroupsId == 3);
        }
        public List<Cities> GetCities()
        {

            return rcity.List();
        }
    }
}
