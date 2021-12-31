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
        Repository<StockViewModel> rsvm = new Repository<StockViewModel>();
        Numaralar num = new Numaralar();
        
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
                GeneralNumber =svm.stockEntryTop.GeneralNumber,


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
                    Barcode = svm.stockEntryLower.ProductCode +"/"+ svm.stockEntryLower.Lot,
                    ProductCode = svm.stockEntryLower.ProductCode,
                    StockCode = num.StockGeneralCode(),
                StockCount = (from s in sel select s.Count).Sum(),
                });
            }

        }
        public void UpdateStatus(StockStatus stockStatus)
        {
            StockStatus ss = rss.Find(s => s.Id == stockStatus.Id);
            ss.ShelfCount = stockStatus.ShelfCount;
            ss.BranchCount = stockStatus.BranchCount;
            ss.ConsigneeCount = stockStatus.ConsigneeCount;
            rss.Update(ss);

        }
        public StockViewModel SVM(string gm)
        {
            var list = (from gsel in GetStockEntryLower()
                        join sa in GetStockEntryTop()
                        on gsel.GeneralNumber equals sa.GeneralNumber                                          
                        select new StockViewModel()
                        {
                            stockEntryTop = sa,
                            stockEntryLower = gsel,                            
                        }).FirstOrDefault(s=> s.stockEntryTop.GeneralNumber==gm);
            return list;
               
        }
        public void SVMUpdate(StockViewModel svm)
        {
            StockEntryLower sel1 = rsel.Find(s => s.GeneralNumber == svm.stockEntryTop.GeneralNumber);
            int selcount = sel1.Count;
            string bar = sel1.Barcode;
            StockEntryTop set1 = rset.Find(s => s.GeneralNumber == svm.stockEntryTop.GeneralNumber);
           


            sel1.ProductCode = svm.stockEntryLower.ProductCode;
            sel1.Lot = svm.stockEntryLower.Lot;
            sel1.Barcode = svm.stockEntryLower.ProductCode + "/" + svm.stockEntryLower.Lot;
            sel1.Count = svm.stockEntryLower.Count;
            sel1.ProductionDate = svm.stockEntryLower.ProductionDate;
            sel1.ExpiryDate = svm.stockEntryLower.ExpiryDate;
            sel1.BuyingPrice = svm.stockEntryLower.BuyingPrice;
            sel1.GeneralNumber = svm.stockEntryTop.GeneralNumber;
            rsel.Update(sel1);

            set1.Description = svm.stockEntryTop.Description;
            set1.GeneralNumber = svm.stockEntryTop.GeneralNumber;
            set1.currentId = svm.stockEntryTop.currentId;
            set1.InvoiceNumber = svm.stockEntryTop.InvoiceNumber;
            set1.InvoiceDate = svm.stockEntryTop.InvoiceDate;
            set1.SaveDate = DateTime.MaxValue;
            set1.UpdateDate = DateTime.MaxValue;
            rset.Update(set1);


            List<StockStatus> sss = rss.List(x => x.Barcode == sel1.Barcode);
            List<StockEntryLower> sel = rsel.List(x => x.Barcode == sel1.Barcode);
            StockStatus ss = rss.Find(x => x.Barcode == sel1.Barcode);
            StockStatus ss2 = rss.Find(x => x.Barcode == bar);
            

            if (sss.Count > 0)
            {
                if (sel1.Barcode==bar)
                {
                    ss.StockCount = (from s in sel select s.Count).Sum();
                    rss.Update(ss);
                }
                else
                {
                    ss2.StockCount -= selcount;
                    ss.StockCount = (from s in sel select s.Count).Sum();
                    
                    rss.Update(ss);
                    rss.Update(ss2);
                }
               
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
