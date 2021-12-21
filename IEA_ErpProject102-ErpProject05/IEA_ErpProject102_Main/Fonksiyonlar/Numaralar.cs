using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEA_ErpProject102_Main.Entitiy;


namespace IEA_ErpProject102_Main.Fonksiyonlar
{
   public class Numaralar
    {
        private readonly ErpProject102Entities erp = new ErpProject102Entities();

        public string CariKoduHastane()
        {
            try
            {
                var numara = (from s in erp.tblCariler orderby s.Id descending select s).First().Id;
                numara++;
                string num ="H" + numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception)
            {
                return "H00000001";

            }
        }

        public string CariKoduDoktor()
        {
            try
            {
                var numara = (from s in erp.tblCariler orderby s.Id descending select s).First().Id;
                numara++;
                string num = "D" + numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception)
            {
                return "D00000001";

            }
        }

        /// <summary>
        /// En son koda bakıp 1 arttırarak bir kod döndürür. Eğer hiç kayıt yoksa P000001 kodunu döndürür
        /// </summary>
        /// <returns></returns>
        public string CariKoduPersonel()
        {
            try
            {
                var numara = (from s in erp.tblCariler orderby s.Id descending select s).First().Id;
                numara++;
                string num = "P" + numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception)
            {
                return "P00000001";

            }
        }

        public string CariKoduFirma()
        {
            try
            {
                var numara = (from s in erp.tblCariler orderby s.Id descending select s).First().Id;
                numara++;
                string num = "F" + numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception)
            {
                return "F00000001";

            }
        }

        public string UrunGenelKodu()
        {
            try
            {
                var numara = (from s in erp.tblUrunler orderby s.Id descending select s).First().Id;
                numara++;
                string num = "U" + numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception)
            {
                return "U00000001";

            }
        }
    }
}
