using ErpMvcProject.DataAccessLayer.EntityFramework;
using ErpMvcProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.BusinessLayer
{
    public class CompanyManager
    {
        Repository<Current> rcur = new Repository<Current>();
        Repository<Cities> rcity = new Repository<Cities>();
        public List<Current> GetCompanies()
        {
            List<Current> cur= rcur.List(x => x.CurrentGroupsId == 3 && x.isActive == true);

            //foreach (Current item in cur)
            //{
            //    item.cTypeId
            //}

            return cur;
        }
        public List<Cities> GetCities()
        {

            return rcity.List();
        }
        DateTime date = DateTime.Now;
        public void CreateCompany(Current cp)
        {
            rcur.Insert(new Current
            {
                cName = cp.cName,
                cMail = cp.cMail,
                CitiesId = cp.CitiesId,
                TaxOffice = cp.TaxOffice,
                cPhone = cp.cPhone,
                sDepartment1 = cp.sDepartment1,
                sDepartment2 = cp.sDepartment2,
                sDepartment3 = cp.sDepartment3,
                sMail1 = cp.sMail1,
                sMail2 = cp.sMail2,
                sMail3 = cp.sMail3,
                sName1 = cp.sName1,
                sName2 = cp.sName2,
                sName3 = cp.sName3,
                sMPhone1 = cp.sMPhone1,
                sMPhone2 = cp.sMPhone2,
                sMPhone3 = cp.sMPhone3,
                isActive = true,
                cCode = cp.cCode,
                cTypeId = cp.cTypeId,
                Address1 = cp.Address1,
                Address2 = cp.Address2,
                SaveDate = date,
                UpdateDate = date,
                SaveUserId = 1,
                UpdateUserId = 1,
                CurrentGroupsId = 3
            });
        }
        public void UpdateCompany(Current current)
        {
            Current c = GetCompanies().FirstOrDefault(x => x.Id == current.Id);
            c.cName = current.cName;
            c.cMail = current.cMail;
            c.CitiesId = current.CitiesId;
            c.TaxOffice = current.TaxOffice;
            c.cPhone = current.cPhone;
            c.sDepartment1 = current.sDepartment1;
            c.sDepartment2 = current.sDepartment2;
            c.sDepartment3 = current.sDepartment3;
            c.sMail1 = current.sMail1;
            c.sMail2 = current.sMail2;
            c.sMail3 = current.sMail3;
            c.sName1 = current.sName1;
            c.sName2 = current.sName2;
            c.sName3 = current.sName3;
            c.sMPhone1 = current.sMPhone1;
            c.sMPhone2 = current.sMPhone2;
            c.sMPhone3 = current.sMPhone3;
            c.cTypeId = current.cTypeId;
            c.Address1 = current.Address1;
            c.Address2 = current.Address2;
            c.UpdateDate = date;
            c.UpdateUserId = 1;
            rcur.Update(c);
        }

        public void CompanyDeleted(Current current)
        {
            //Current c = GetCompanies().FirstOrDefault(x => x.Id == current.Id);
            current.UpdateDate = date;
            current.UpdateUserId = 1;
            current.isActive = false;
            rcur.Update(current);
        }
    }
}
