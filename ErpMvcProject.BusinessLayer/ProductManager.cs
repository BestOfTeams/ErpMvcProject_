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
        public void AddDist()
        {
          var liste=  rdist.List(x => x.CurrentGroupsId == 3);
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
    }
}
// sorular
//EcposureTime neden decimal 
//Html.Dropdownfor neden kullanılamıyor
//List(selectIndex)i nasıl kullanırım
//PCode nasıl üretirim
//
