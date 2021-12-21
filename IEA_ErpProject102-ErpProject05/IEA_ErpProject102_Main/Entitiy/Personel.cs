using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject102_Main.Entity
{

    public class Personel
    {
        //public Personel(int id, string kod, string ad, string telNo, string eMail, string cepNo, DateTime baslamaTarih, DateTime bitisTarih)
        //{
        //    Id = id;
        //    Kod = kod;
        //    Ad = ad;
        //    TelNo = telNo;
        //    EMail = eMail;
        //    CepNo = cepNo;
        //    BaslamaTarih = baslamaTarih;
        //    BitisTarih = bitisTarih;
        //}

        public int Id { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public string TelNo { get; set; }
        public string EMail { get; set; }
        public string CepNo { get; set; }
        public Nullable<DateTime> BaslamaTarih { get; set; }
        public Nullable<DateTime> BitisTarih { get; set; }

    }
}
