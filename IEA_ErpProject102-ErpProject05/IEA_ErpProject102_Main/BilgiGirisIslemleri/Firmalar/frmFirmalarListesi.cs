using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject102_Main.Entitiy;
using IEA_ErpProject102_Main.Fonksiyonlar;

namespace IEA_ErpProject102_Main.BilgiGirisIslemleri.Firmalar
{
    public partial class frmFirmalarListesi : Form
    {
        private ErpProject102Entities erp = new ErpProject102Entities();
        private Numaralar n = new Numaralar();
        public int secimId = -1;
        public frmFirmalarListesi()
        {
            InitializeComponent();
        }

        private void frmFirmalarListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblCariler
                where s.isActive == true
                where s.CariGrupId == 3
                select new
                {
                    id = s.Id,
                    hcode = s.CariKodu,
                    hadi = s.CariAdi,
                    htel = s.CariTel,
                    hmail = s.CariMail,
                    hyet = s.YetkiliAdi1,
                    hyetcep = s.YetkiliCep1
                }).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.hcode;
                Liste.Rows[i].Cells[3].Value = k.hadi;
                Liste.Rows[i].Cells[4].Value = k.htel;
                Liste.Rows[i].Cells[5].Value = k.hmail;
                Liste.Rows[i].Cells[6].Value = k.hyet;
                Liste.Rows[i].Cells[7].Value = k.hyetcep;
                i++;
                sira++;
            }

            Liste.AllowUserToAddRows = false;
            lblFirmaKodu.Text = n.CariKoduFirma();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;

            if (secimId > 0 && Application.OpenForms["frmFirmaGiris"] == null)
            {

                frmFirmaGiris frm = new frmFirmaGiris();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
                frm.Ac(secimId);
                Close();
            }
            else if (Application.OpenForms["frmFirmaGiris"] != null)
            {
                frmFirmaGiris frm1 = Application.OpenForms["frmFirmaGiris"] as frmFirmaGiris;
                frm1.Ac(secimId);
                Close();
            }
        }
    }
}
