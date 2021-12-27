using ErpMvcProject.DataAccessLayer.EntityFramework;
using ErpMvcProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.BusinessLayer
{
   public class ProductManager
    {
        
        //int son= context.currents.OrderByDescending(x => x.Id).First().Id;
        Repository<Products> rpro = new Repository<Products>();
        Repository<Current> rdist = new Repository<Current>();
        public List<Products> GetProducts()
        {
            return rpro.List();
        }
        public List<Current> GetDist()
        {
            return rdist.List(x => x.CurrentGroupsId == 3 && x.isActive==true);
        }



        public void EnterProduct(Products products)
        {
            int islem = rpro.Insert(new Products()
            {
                PDiscription = products.PDiscription,
                PName = products.PName,
                BuyingPrice = products.BuyingPrice,
                BoxContents = products.BoxContents,
                isActive = products.isActive,
                cDispId = products.cDispId,
                SalePrice = products.SalePrice,
                PGeneralNumber = FakeData.NumberData.GetNumber(1, 100).ToString(),
                ExposureTime=15
            }) ;
          
        }
        public void UpdateProduct(Products products,int? id)
        {
            Products pId = rpro.Find(x=> x.Id==id);
            pId.PName = products.PName;
            pId.PDiscription = products.PDiscription;
            pId.SalePrice = products.SalePrice;
            pId.BuyingPrice = products.BuyingPrice;
            pId.BoxContents = products.BoxContents;
            pId.cDispId = products.cDispId;
            pId.ExposureTime = products.ExposureTime;
            pId.isActive = products.isActive;
            pId.UpdateDate = DateTime.Now;
            int update = rpro.Update(pId);
        }
        public Products FindUpdate(int? id)
        {
            return rpro.Find(x=> x.Id==id);
        }
        public void DeleteProduct(int? id)
        {
            Products pId = rpro.Find(x => x.Id == id);
            rpro.Delete(pId);
        }
        //public void Pcode()
        //{
            
        //}

    }
}

// sorular
//EcposureTime neden decimal 
//Html.Dropdownfor neden kullanılamıyor
//List(selectIndex)i nasıl kullanırım
//PCode nasıl üretirim
//
