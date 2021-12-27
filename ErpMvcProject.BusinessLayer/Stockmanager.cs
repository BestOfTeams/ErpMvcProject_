using ErpMvcProject.DataAccessLayer.EntityFramework;
using ErpMvcProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.BusinessLayer
{
    public class Stockmanager
    {
        Repository<StockStatus> rss = new Repository<StockStatus>();
        Repository<StockEntryLower> rsel = new Repository<StockEntryLower>();
        Repository<Current> rcur = new Repository<Current>();
        Repository<Products> rpro = new Repository<Products>();
        Repository<StockEntryTop> rset = new Repository<StockEntryTop>();
        public List<StockStatus> GetStockStatus()
        {
            return rss.List();
        }
        public List<StockEntryLower> GetStockEntryLower()
        {
            return rsel.List();
        }
        public List<StockEntryTop> GetStockEntryTop()
        {
            return rset.List();
        }
        public List<Current> GetCurrent()
        {
            return rcur.List(x => x.CurrentGroupsId == 3 && x.cTypeId == 1 && x.isActive==true);
        }
        public List<Products> GetProduct()
        {
            return rpro.List();
        }
        public void CreateStock(StockViewModel svm)
        {
            rsel.Insert(new StockEntryLower
            {
                ProductCode = svm.stockEntryLower.ProductCode,
                Lot = svm.stockEntryLower.Lot,
                Barcode = svm.stockEntryLower.ProductCode + "/" + svm.stockEntryLower.Lot,
                Count = svm.stockEntryLower.Count,
                ProductionDate = svm.stockEntryLower.ProductionDate,
                ExpiryDate = svm.stockEntryLower.ExpiryDate,
                BuyingPrice = svm.stockEntryLower.BuyingPrice,
                GeneralNumber = Convert.ToInt32(svm.stockEntryTop.GeneralNumber),


            });
            rset.Insert(new StockEntryTop
            {
                Description = svm.stockEntryTop.Description,
                GeneralNumber = svm.stockEntryTop.GeneralNumber,
                currentId = svm.stockEntryTop.currentId,
                InvoiceNumber = svm.stockEntryTop.InvoiceNumber,
                InvoiceDate = svm.stockEntryTop.InvoiceDate,
                SaveDate = DateTime.MaxValue,
                UpdateDate = DateTime.MaxValue


            });
            List<StockStatus> sss = rss.List(x => x.Barcode == svm.stockEntryLower.Barcode);
            List<StockEntryLower> sel = rsel.List(x => x.Barcode == svm.stockEntryLower.Barcode);

            string bar = svm.stockEntryLower.Barcode;
            if (sss.Count > 0)
            {
               

                StockStatus ss = rss.Find(x => x.Barcode ==svm.stockEntryLower.Barcode);
                ss.StockCount = (from s in sel select s.Count).Sum();
                rss.Update(ss);
            }
            else
            {
                rss.Insert(new StockStatus
                {
                    Lot = svm.stockEntryLower.Lot,
                    Barcode = svm.stockEntryLower.ProductCode + "/" + svm.stockEntryLower.Lot,
                    ProductCode = svm.stockEntryLower.ProductCode,
                    StockCode = svm.stockEntryTop.GeneralNumber,                    
                    StockCount = (from s in sel select s.Count).Sum(),
                });
            }



        }
    }
}
