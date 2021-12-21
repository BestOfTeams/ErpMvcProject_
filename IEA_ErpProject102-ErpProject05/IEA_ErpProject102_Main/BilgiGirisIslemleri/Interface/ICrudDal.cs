using IEA_ErpProject102_Main.BilgiGirisIslemleri.Inheratances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject102_Main.BilgiGirisIslemleri.Interface
{
   public interface ICrudDal
    {
        void Listele();
        void YeniKayit();
        void Guncelle();
        void Sil();
        void Ac(int id);
        void Temizle();
    }
}
