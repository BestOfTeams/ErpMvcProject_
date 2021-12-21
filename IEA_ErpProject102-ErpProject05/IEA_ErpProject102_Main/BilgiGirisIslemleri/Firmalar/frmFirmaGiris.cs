using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using IEA_ErpProject102_Main.BilgiGirisIslemleri.Inheratances;
using IEA_ErpProject102_Main.BilgiGirisIslemleri.Interface;
using IEA_ErpProject102_Main.Entitiy;
using IEA_ErpProject102_Main.Fonksiyonlar;
using IEA_ErpProject102_Main.Properties;

namespace IEA_ErpProject102_Main.BilgiGirisIslemleri.Firmalar
{
    public partial class frmFirmaGiris : FormUst,ICrudDal
    {
       
        public frmFirmaGiris()
        {
            InitializeComponent();
        }

        private void frmFirmaGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }
        //private void Listele()
        //{
        //    Liste.Rows.Clear();
        //    int i = 0, sira = 1;
        //    var lst = (from s in erp.tblCariler
        //        where s.isActive == true
        //        where s.CariGrupId == 3
        //        select new
        //        {
        //            id = s.Id,
        //            hcode = s.CariKodu,
        //            hadi = s.CariAdi,
        //            htel = s.CariTel,
        //            hmail = s.CariMail,
        //            hyet = s.YetkiliAdi1,
        //            hyetcep = s.YetkiliCep1
        //        }).ToList();
        //    foreach (var k in lst)
        //    {
        //        Liste.Rows.Add();
        //        Liste.Rows[i].Cells[0].Value = k.id;
        //        Liste.Rows[i].Cells[1].Value = sira;
        //        Liste.Rows[i].Cells[2].Value = k.hcode;
        //        Liste.Rows[i].Cells[3].Value = k.hadi;
        //        Liste.Rows[i].Cells[4].Value = k.htel;
        //        Liste.Rows[i].Cells[5].Value = k.hmail;
        //        Liste.Rows[i].Cells[6].Value = k.hyet;
        //        Liste.Rows[i].Cells[7].Value = k.hyetcep;
        //        i++;
        //        sira++;
        //    }

        //    Liste.AllowUserToAddRows = false;
        //    lblFirmaKodu.Text = n.CariKoduFirma();
        //}
        private void ComboDoldur()
        {
            txtFTipi.DataSource = Enum.GetValues(typeof(enumFirmaTipi));
            var lst = erp.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            var lst1 = erp.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            var lst2 = erp.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            var lst3 = erp.tblSehirler.ToList();

            //txtDepartman1.Items.Clear();
            txtFDept1.DataSource = lst;
            txtFDept1.ValueMember = "Id";
            txtFDept1.DisplayMember = "DeptAdi";
            txtFDept1.SelectedIndex = -1;

            //txtDepartman2.Items.Clear();
            txtFDept2.DataSource = lst1;
            txtFDept2.ValueMember = "Id";
            txtFDept2.DisplayMember = "DeptAdi";
            txtFDept2.SelectedIndex = -1;

            //txtDepartman3.Items.Clear();
            txtFDept3.DataSource = lst2;
            txtFDept3.ValueMember = "Id";
            txtFDept3.DisplayMember = "DeptAdi";
            txtFDept3.SelectedIndex = -1;

            //txtSehir.Items.Clear();
            txtSehir.DataSource = lst3;
            txtSehir.ValueMember = "id";
            txtSehir.DisplayMember = "Sehir";
            txtSehir.SelectedIndex = -1;
        }
        private void YeniKayit()
        {
            string fkodu = n.CariKoduFirma();
            try
            {
                if (txtFAdi.Text == "")
                {
                    return;
                }
                if (secimId == -1)
                {
                    tblCariler hst = new tblCariler();
                    hst.isActive = true;
                    hst.CariAdi = txtFAdi.Text;
                    hst.CariMail = txtFMail.Text;
                    hst.CariTel = txtFTel.Text;
                    hst.YetkiliAdi1 = txtFYet1.Text;
                    hst.YetkiliAdi2 = txtFYet2.Text;
                    hst.YetkiliAdi3 = txtFYet3.Text;
                    hst.YetkiliDep1 = txtFDept1.Text;
                    hst.YetkiliDep2 = txtFDept2.Text;
                    hst.YetkiliDep3 = txtFDept3.Text;
                    hst.YetkiliTel1 = txtFYtel1.Text;
                    hst.YetkiliTel2 = txtFYtel2.Text;
                    hst.YetkiliTel3 = txtFYtel3.Text;
                    hst.YetkiliCep1 = txtFYcep1.Text;
                    hst.YetkiliCep2 = txtFYcep2.Text;
                    hst.YetkiliCep3 = txtFYcep3.Text;
                    hst.YetkiliMail1 = txtFYEmail1.Text;
                    hst.YetkiliMail2 = txtFYEmail2.Text;
                    hst.YetkiliMail3 = txtFYEmail3.Text;
                    hst.Adres1 = txtFAdres1.Text;
                    hst.Adres2 = txtFAdres2.Text;
                    hst.CariGrupId = 3;
                    hst.CariTipId = (int)txtFTipi.SelectedValue;

                    hst.VDairesi = txtVergiDairesi.Text;
                    hst.VnoTcno = txtVnTc.Text;
                    if (txtSehir.Text != "")
                    {
                        hst.SehirId = (int?)txtSehir.SelectedValue ?? -1;
                    }
                    hst.SaveUserId = 1;
                    hst.SaveDate = DateTime.Now;
                    hst.CariKodu = fkodu;

                    erp.tblCariler.Add(hst);
                    erp.SaveChanges();

                    MessageBox.Show("Kayit basarili");
                    Temizle();
                    Listele();
                }
                else
                {
                    MessageBox.Show("Bu kayit daha once yapilmis. Kendine baska kayit bul...");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void Guncelle()
        {
            if (secimId < 0)
            {
                return;
            }
            try
            {
                tblCariler hst = erp.tblCariler.Find(secimId);
                hst.CariAdi = txtFAdi.Text;
                hst.CariMail = txtFMail.Text;
                hst.CariTel = txtFTel.Text;
                hst.YetkiliAdi1 = txtFYet1.Text;
                hst.YetkiliAdi2 = txtFYet2.Text;
                hst.YetkiliAdi3 = txtFYet3.Text;
                hst.YetkiliDep1 = txtFDept1.Text;
                hst.YetkiliDep2 = txtFDept2.Text;
                hst.YetkiliDep3 = txtFDept3.Text;
                hst.YetkiliTel1 = txtFYtel1.Text;
                hst.YetkiliTel2 = txtFYtel2.Text;
                hst.YetkiliTel3 = txtFYtel3.Text;
                hst.YetkiliCep1 = txtFYcep1.Text;
                hst.YetkiliCep2 = txtFYcep2.Text;
                hst.YetkiliCep3 = txtFYcep3.Text;
                hst.YetkiliMail1 = txtFYEmail1.Text;
                hst.YetkiliMail2 = txtFYEmail2.Text;
                hst.YetkiliMail3 = txtFYEmail3.Text;
                hst.Adres1 = txtFAdres1.Text;
                hst.Adres2 = txtFAdres2.Text;
                hst.CariGrupId = 3;
                if (txtFTipi.Text != "")
                {
                    hst.CariTipId = (int)txtFTipi.SelectedValue;
                }
                hst.VDairesi = txtVergiDairesi.Text;
                hst.VnoTcno = txtVnTc.Text;
                hst.SehirId = (int?)txtSehir.SelectedValue ?? -1;
                hst.UpdateUserId = 1;
                hst.UpdateDate = DateTime.Now;


                erp.SaveChanges();

                MessageBox.Show("Guncelleme basarili");
                Temizle();
                Listele();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void Temizle()
        {
            foreach (Control k in pnlOrta.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox)
                {
                    k.Text = "";
                }
            }

            secimId = -1;
        }

        public void Ac(int id)
        {
            secimId = id; //dis formdan veri gelirse secimId hatasi almamak icin bu islemi yaptim
            try
            {
                tblCariler hst = erp.tblCariler.Find(id);
                txtFAdi.Text = hst.CariAdi;
                txtFMail.Text = hst.CariMail;
                txtFTel.Text = hst.CariTel;
                txtFYet1.Text = hst.YetkiliAdi1;
                txtFYet2.Text = hst.YetkiliAdi2;
                txtFYet3.Text = hst.YetkiliAdi3;
                txtFDept1.Text = hst.YetkiliDep1;
                txtFDept2.Text = hst.YetkiliDep2;
                txtFDept3.Text = hst.YetkiliDep3;
                txtFYtel1.Text = hst.YetkiliTel1;
                txtFYtel2.Text = hst.YetkiliTel2;
                txtFYtel3.Text = hst.YetkiliTel3;
                txtFYcep1.Text = hst.YetkiliCep1;
                txtFYcep2.Text = hst.YetkiliCep2;
                txtFYcep3.Text = hst.YetkiliCep3;
                txtFYEmail1.Text = hst.YetkiliMail1;
                txtFYEmail2.Text = hst.YetkiliMail2;
                txtFYEmail3.Text = hst.YetkiliMail3;
                txtFAdres1.Text = hst.Adres1;
                txtFAdres2.Text = hst.Adres2;
                txtVergiDairesi.Text = hst.VDairesi;
                txtVnTc.Text = hst.VnoTcno;
                if (hst.tblSehirler != null)
                {
                    txtSehir.Text = hst.tblSehirler.sehir;
                }
                else
                {
                    txtSehir.Text = "";
                }

                lblFirmaKodu.Text = hst.CariKodu;
                txtKayitBul.Text = hst.CariKodu;
                txtFTipi.Text = Enum.GetName(typeof(enumFirmaTipi), hst.CariTipId);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25, txtKayitBul.ClientSize.Height + 0);
            btn.Location = new Point(txtKayitBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.Image = Resources.arrow_1176;
            txtKayitBul.Controls.Add(btn);
            //SendMessage(txtKayitBul.Handle, 0xd3, (IntPtr)2, (IntPtr)(btn.Width << 16));
            base.OnLoad(e);
            btn.Click += btn_Click;
        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private void btn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmFirmalarListesi"] == null)
            {
                frmFirmalarListesi frm = new frmFirmalarListesi();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            SendToBack();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                tblCariler hst = erp.tblCariler.Find(secimId);
                hst.isActive = false;
                erp.SaveChanges();
                MessageBox.Show("Silme basarili");
                Temizle();
                Listele();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Listele()
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

        void ICrudDal.YeniKayit()
        {
            throw new NotImplementedException();
        }

        void ICrudDal.Guncelle()
        {
            throw new NotImplementedException();
        }

        public void Sil()
        {
            throw new NotImplementedException();
        }

        void ICrudDal.Temizle()
        {
            throw new NotImplementedException();
        }
    }
}

