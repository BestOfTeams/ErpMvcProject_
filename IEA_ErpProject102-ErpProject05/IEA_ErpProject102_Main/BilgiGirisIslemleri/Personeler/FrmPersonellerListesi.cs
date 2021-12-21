using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject102_Main.BilgiGirisIslemleri.Doktorlar;
using IEA_ErpProject102_Main.Entitiy;
using IEA_ErpProject102_Main.Fonksiyonlar;

namespace IEA_ErpProject102_Main.BilgiGirisIslemleri.Personeler
{
    public partial class FrmPersonellerListesi : Form
    {
        private ErpProject102Entities erp = new ErpProject102Entities();
        private Numaralar n = new Numaralar();
        private int secimId = -1;
        public FrmPersonellerListesi()
        {
            InitializeComponent();
        }

        private void FrmPersonellerListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblPersonelDetay
                where s.tblCariler.isActive == true
                where s.tblCariler.CariGrupId == 4
                select new
                {
                    id = s.Id,
                    dkodu = s.tblCariler.CariKodu,
                    dadi = s.tblCariler.CariAdi,
                    dtel = s.tblCariler.CariTel,
                    dmail = s.tblCariler.CariMail,
                    dyetcep = s.tblCariler.YetkiliCep1,
                    dgtarih = s.IsBasiTarih,
                    dbtarih = s.IsBitisTarih
                }).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.dkodu;
                Liste.Rows[i].Cells[3].Value = k.dadi;
                Liste.Rows[i].Cells[4].Value = k.dtel;
                Liste.Rows[i].Cells[5].Value = k.dyetcep;
                Liste.Rows[i].Cells[6].Value = k.dmail;
                Liste.Rows[i].Cells[7].Value = k.dgtarih;
                Liste.Rows[i].Cells[8].Value = k.dbtarih;
                i++;
                sira++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblHastaneKodu.Text = n.CariKoduPersonel();

        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            if (secimId > 0 && Application.OpenForms["FrmPersonelGiris"] == null)
            {
                FrmPersonelGiris frm = new FrmPersonelGiris();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
                frm.Ac(secimId);
                Close();
            }
            else if (Application.OpenForms["FrmPersonelGiris"] != null)
            {
                FrmPersonelGiris frm = Application.OpenForms["FrmPersonelGiris"] as FrmPersonelGiris;
                frm.Ac(secimId);
                Close();
            }
        }

        private void Liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
