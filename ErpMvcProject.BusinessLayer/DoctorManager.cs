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
        Repository<Cities> rcity = new Repository<Cities>();
        DateTime date = DateTime.Now;
        public List<Current> GetDoctors()
        {
            return rcur.List(x => x.CurrentGroupsId == 1 && x.isActive==true);
        }
        public List<Cities> GetCities()
        {

            return rcity.List();
        }

        public void CreateDoctor(Current current)
        {
           
            rcur.Insert(new Current
            {
                cName = current.cName,
                CitiesId =current.CitiesId,
                Title=current.Title,
                Address1=current.Address1,
                Address2=current.Address2,
                TcId=current.TcId,
                cPhone=current.cPhone,
                sMPhone1=current.sMPhone1,
                cMail=current.cMail,
                isActive=current.isActive,
                CurrentGroupsId=1,
                cCode=current.cCode,
                SaveDate= date,
                UpdateDate= date,
                UpdateUserId=1,
                SaveUserId=1

            });
                

            
        }
        public Current Find(int id)
        {
            return rcur.Find(x => x.Id == id);
        }

        public void UpdateDoctor(Current current)
        {
            Current c = rcur.Find(x => x.Id == current.Id);
            c.cName = current.cName;
            c.CitiesId = current.CitiesId;
            c.Title = current.Title;
            c.Address1 = current.Address1;
            c.Address2 = current.Address2;
            c.TcId = current.TcId;
            c.cPhone = current.cPhone;
            c.sMPhone1 = current.sMPhone1;
            c.cMail = current.cMail;
            c.isActive = current.isActive;            
            c.UpdateDate = date;
            c.UpdateUserId = 1;           
            rcur.Update(c);
        }

        public void DeleteDoctor(int dId)
        {
            Current c = rcur.Find(x => x.Id == dId);
            rcur.Delete(c);
        }
    }
}
