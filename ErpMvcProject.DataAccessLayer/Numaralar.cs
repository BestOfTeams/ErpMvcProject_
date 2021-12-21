using ErpMvcProject.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.DataAccessLayer
{
    internal class Numaralar
    {
        private readonly ErpMvcContext erp = new ErpMvcContext();

        public string CCodeHospital()
        {
            try
            {
                var numara = (from s in erp.currents orderby s.Id descending select s).First().Id;
                numara++;
                string num = "H" + numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception)
            {
                return "H00000001";

            }
        }

        public string CCodeDoctor()
        {
            try
            {
                var numara = (from s in erp.currents orderby s.Id descending select s).First().Id;
                numara++;
                string num = "D" + numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception)
            {
                return "D00000001";

            }
        }

        public string CCodeEmployee()
        {
            try
            {
                var numara = (from s in erp.currents orderby s.Id descending select s).First().Id;
                numara++;
                string num = "E" + numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception)
            {
                return "E00000001";

            }
        }

        public string CCodeCompany()
        {
            try
            {
                var numara = (from s in erp.currents orderby s.Id descending select s).First().Id;
                numara++;
                string num = "C" + numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception)
            {
                return "C00000001";

            }
        }

        public string ProductGeneralCode()
        {
            try
            {
                var numara = (from s in erp.currents orderby s.Id descending select s).First().Id;
                numara++;
                string num = "P" + numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception)
            {
                return "P00000001";

            }
        }

        public string StockGeneralCode()
        {
            try
            {
                var numara = (from s in erp.stockEntryTops orderby s.Id descending select s).First().Id;
                numara++;
                string num = numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception)
            {
                return "00000001";

            }
        }
    }
}
