using ErpMvcProject.DataAccessLayer.Entity;
using ErpMvcProject.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.DataAccessLayer.EntityFramework
{
    public class MyInitializer : CreateDatabaseIfNotExists<ErpMvcContext>
    {



        //public class MyInitializer 
        //{
        //    public MyInitializer()
        //    {
        Random rnd = new Random();
        protected override void Seed(ErpMvcContext context)
        {
            for (int i = 0; i < 81; i++)
            {
                Cities city = new Cities()
                {
                    City = FakeData.PlaceData.GetCity()
                };
                context.cities.Add(city);
            }//Cities

            context.SaveChanges();
            string[] CGroups = new string[4] { "Doctors", "Employees", "Companies", "Hospitals" };

            for (int i = 0; i < CGroups.Length; i++)
            {
                CurrentGroups cgrup = new CurrentGroups()
                {
                    gName = CGroups[i],
                    isActive = true
                };
                context.currentGroups.Add(cgrup);

                for (int d = 0; d < 4; d++)
                {

                    if (i == 0)
                    {
                        Departments dep = new Departments()
                        {
                            DepName = FakeData.NameData.GetCompanyName(),
                            isActive = true,
                            CurrentGroupsId = 1
                        };
                        context.departments.Add(dep);
                    }
                    else if (i == 1)
                    {
                        Departments dep = new Departments()
                        {
                            DepName = FakeData.NameData.GetCompanyName(),
                            isActive = true,
                            CurrentGroupsId = 2
                        };
                        context.departments.Add(dep);
                    }
                    else if (i == 2)
                    {
                        Departments dep = new Departments()
                        {
                            DepName = FakeData.NameData.GetCompanyName(),
                            isActive = true,
                            CurrentGroupsId = 3
                        };
                        context.departments.Add(dep);
                    }
                    else
                    {
                        Departments dep = new Departments()
                        {
                            DepName = FakeData.NameData.GetCompanyName(),
                            isActive = true,
                            CurrentGroupsId = 4
                        };
                        context.departments.Add(dep);
                    }
                }//departmans


            }
            context.SaveChanges();
            int ho = 1;
            int co = 1;
            int em = 1;
            int doc = 1;
            int po = 1;
            int po2 = 1;
            string[] aaa = Enum.GetNames(typeof(enumDoctors));
            for (int c = 0; c < 25; c++)
            {
                Current current = new Current();
                current.isActive = true;
                current.SaveDate = DateTime.Now;
                current.SaveUserId=1;
                current.UpdateDate=DateTime.Now;
                current.UpdateUserId=1;
                current.cName = FakeData.NameData.GetFirstName();
                current.cMail = FakeData.NetworkData.GetEmail();
                current.Address1 = FakeData.PlaceData.GetAddress();
                current.Address2 = FakeData.PlaceData.GetAddress();
                current.CitiesId = FakeData.NumberData.GetNumber(1, 81);
                current.cPhone = FakeData.PhoneNumberData.GetPhoneNumber();
                current.TcId = FakeData.TextData.GetNumeric(11);
                current.CurrentGroupsId = FakeData.NumberData.GetNumber(1,5);
                if (current.CurrentGroupsId == 1)
                {                                      
                    current.Title = aaa[rnd.Next(FakeData.NumberData.GetNumber(1,8))].ToString();                                      
                    //current.Title = rnd.Next(Enum.GetNames(typeof(enumDoctors))).ToString();
                    //current.Title = rnd.Next(aaa[1].).ToString();
                    current.TaxOffice = FakeData.PlaceData.GetState();
                    current.sMPhone1 = FakeData.PhoneNumberData.GetPhoneNumber();
                    current.cCode = "D" + doc++.ToString().PadLeft(8, '0');
                }
                else if (current.CurrentGroupsId == 2)
                {
                   
                    current.Title = rnd.Next(Enum.GetNames(typeof(Employees)).Length).ToString();
                    current.cCode = "E" + em++.ToString().PadLeft(8, '0');
                }
                else
                {
                    
                    current.TaxOffice = FakeData.PlaceData.GetState();
                    current.sName1 = FakeData.NameData.GetFullName();
                    current.sName2 = FakeData.NameData.GetFullName();
                    current.sName3 = FakeData.NameData.GetFullName();
                    current.sPhone1 = FakeData.PhoneNumberData.GetPhoneNumber();
                    current.sPhone2 = FakeData.PhoneNumberData.GetPhoneNumber();
                    current.sPhone3 = FakeData.PhoneNumberData.GetPhoneNumber();
                    current.sMPhone1 = FakeData.PhoneNumberData.GetPhoneNumber();
                    current.sMPhone2 = FakeData.PhoneNumberData.GetPhoneNumber();
                    current.sMPhone3 = FakeData.PhoneNumberData.GetPhoneNumber();
                    current.sMail1 = FakeData.NetworkData.GetEmail();
                    current.sMail2 = FakeData.NetworkData.GetEmail();
                    current.sMail3 = FakeData.NetworkData.GetEmail();
                    current.sDepartment1 = FakeData.NumberData.GetNumber(1,4).ToString();
                    current.sDepartment2 = FakeData.NumberData.GetNumber(1,4).ToString();
                    current.sDepartment3 = FakeData.NumberData.GetNumber(1,4).ToString();
                }
                if (current.CurrentGroupsId == 4)
                {
                    current.cCode = "H" + ho++.ToString().PadLeft(8, '0');
                }
                if (current.CurrentGroupsId == 3)
                {
                    current.cTypeId = 1;
                    current.cCode = "C" + co++.ToString().PadLeft(8, '0');// rnd.Next(Enum.GetNames(typeof(Company)).Length);
                }
                
                context.currents.Add(current);
            }
            context.SaveChanges();
            List<Current> employeeList = context.currents.Where(s=> s.CurrentGroupsId==2 && s.cTypeId==1).ToList();
            for (int i = 0; i < employeeList.Count; i++)
            {
                EmployeeDetails ed = new EmployeeDetails();
                ed.FirstDate = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-3), DateTime.Now);
                ed.EndDate = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-2), DateTime.Now);
                ed.CurrentId = employeeList[i];
                context.employeeDetails.Add(ed);
            } 
            context.SaveChanges();
            List<Current> companyList = context.currents.Where(s => s.CurrentGroupsId == 3).ToList();
            int a = 1;
            for (int i = 0; i < companyList.Count; i++) 
            {
                Products pro = new Products();
                pro.cDispId = companyList[i];
                pro.BoxContents = FakeData.TextData.GetSentences(5);
                pro.BuyingPrice = FakeData.NumberData.GetNumber(20, 100);
                pro.SalePrice = FakeData.NumberData.GetNumber(20, 100);
                pro.isActive = true;
                pro.PDiscription= FakeData.TextData.GetSentences(5);
                pro.PGeneralNumber = FakeData.NumberData.GetNumber(1,100).ToString();
                pro.PName = FakeData.NameData.GetCompanyName();
                pro.PCode= "P" + (a++).ToString().PadLeft(8, '0');
               // var numara = (from s in context.products orderby s.Id descending select s).First();
                context.products.Add(pro);
            }
            context.SaveChanges();
            int b = 1;
            List<CurrentGroups> groupList = context.currentGroups.Where(s => s.Id == 3).ToList();
            for (int i = 0; i < 5; i++)
            {
                StockEntryTop set = new StockEntryTop();
                set.GeneralNumber = Convert.ToInt32((b++).ToString().PadLeft(8, '0'));
                set.cId = companyList[i];
                set.cGroupId = groupList[0];
              set.Description = FakeData.TextData.GetSentences(3);
                set.InvoiceNumber = (b++).ToString().PadLeft(8, '0');
                set.InvoiceDate = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-5), DateTime.Now);
                set.isActive = true;
                set.EntryType= FakeData.NumberData.GetNumber(1, 2);
                set.SaveDate = DateTime.Now;
                set.UpdateDate = DateTime.Now;
                set.SaveUserId = 1;
                set.UpdateUserId = 1;
                context.stockEntryTops.Add(set);
            }
            context.SaveChanges();
           // List<StockEntryTop> stockEntryTopsList = context.stockEntryTops.ToList();
            for (int i = 1; i <= 5; i++)
            {
                StockEntryLower sel = new StockEntryLower();
                sel.BuyingPrice = FakeData.NumberData.GetNumber(20, 100);
                sel.Count = FakeData.NumberData.GetNumber(20, 100);
                sel.ExpiryDate = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(1), DateTime.Now.AddYears(3));
                sel.ProductionDate = FakeData.DateTimeData.GetDatetime(DateTime.Now, DateTime.Now.AddYears(1));
                sel.OrderNumber = FakeData.NumberData.GetNumber(1, 100);
                sel.Note = FakeData.TextData.GetSentences(2);
                sel.GeneralNumber = Convert.ToInt32((b++).ToString().PadLeft(8, '0'));
              //  int number=(from s in erp.currents orderby s.Id descending select s).First().Id;
                int number1=context.currents.OrderByDescending(x=>x.Id).First().Id;
                sel.ProductCode = "P"+(number1+1).ToString().PadLeft(8, '0');
                sel.Lot = "1";
                sel.Barcode = sel.ProductCode + " / " + sel.Lot;
                context.stockEntryLowers.Add(sel);
            }
            context.SaveChanges();
            for (int i = 1; i <= 5; i++)
            {
                StockStatus ss = new StockStatus();
                ss.BranchCount= FakeData.NumberData.GetNumber(20, 100);
                ss.ShelfCount= FakeData.NumberData.GetNumber(20, 100);
                ss.StockCount= FakeData.NumberData.GetNumber(20, 100);
                ss.ConsigneeCount= FakeData.NumberData.GetNumber(20, 100);
                ss.ProductCode= "P" + (po).ToString().PadLeft(8, '0');
                ss.Lot = "1";
                ss.Barcode= ss.ProductCode + " / " + ss.Lot;
                ss.StockCode = (po2).ToString().PadLeft(8, '0');
                ss.ProductionDate= FakeData.DateTimeData.GetDatetime(DateTime.Now, DateTime.Now.AddYears(1));
                ss.ExpiryDate = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(1), DateTime.Now.AddYears(3));
                context.stockStatuses.Add(ss);
            }
            context.SaveChanges();
        }

    }
}
