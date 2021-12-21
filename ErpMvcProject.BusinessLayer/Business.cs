using ErpMvcProject.DataAccessLayer.Entity;
using ErpMvcProject.DataAccessLayer.EntityFramework;
using ErpMvcProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.BusinessLayer
{
    public class Business
    {
        Repository<Current> RCurrent = new Repository<Current>();
        Repository<CurrentGroups> RCurrentGroups = new Repository<CurrentGroups>();
        Repository<Products> RProduct= new Repository<Products>();
        Repository<Cities> RCities = new Repository<Cities>();
        Repository<EmployeeDetails> Remp = new Repository<EmployeeDetails>();
        Repository<StockStatus> RSS = new Repository<StockStatus>();
        Repository<StockEntryTop> RSet = new Repository<StockEntryTop>();
        Repository<StockEntryLower> RSel = new Repository<StockEntryLower>();
        Repository<Departments> RDep = new Repository<Departments>();
        public Business()
        {
            ErpMvcContext db = new ErpMvcContext();
            db.currents.ToList();
          //  var currentList = RCurrent.List();
          //  var currentListforwhere = RCurrent.List(x => x.CurrentGroupsId == 3);
        }
        
    }
}
