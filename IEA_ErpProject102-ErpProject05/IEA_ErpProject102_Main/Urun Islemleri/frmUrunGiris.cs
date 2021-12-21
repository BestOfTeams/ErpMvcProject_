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
using IEA_ErpProject102_Main.BilgiGirisIslemleri.Firmalar;
using IEA_ErpProject102_Main.Entitiy;
using IEA_ErpProject102_Main.Fonksiyonlar;
using IEA_ErpProject102_Main.Properties;

namespace IEA_ErpProject102_Main.Urun_Islemleri
{
    public partial class frmUrunGiris : Form
    {
        private ErpProject102Entities erp = new ErpProject102Entities();
        private Numaralar n = new Numaralar();
        private int secimId = -1;

        public frmUrunGiris()
        {
            InitializeComponent();
        }

        private void frmUrunGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();

        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblUrunler
                       where s.isActive == true
                       select s).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.UrunGenelNo;
                Liste.Rows[i].Cells[3].Value = k.UrunKodu;
                Liste.Rows[i].Cells[4].Value = k.UrunAdi;
                i++;
                sira++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lblUrunKodu.Text = n.UrunGenelKodu();
            txtKayitBul.Text = n.UrunGenelKodu();
        }

        private void ComboDoldur()
        {
            txtDistributor.DataSource = (from s in erp.tblCariler
                                         where s.CariGrupId == 3
                                         where s.CariTipId == 1
                                         select s).ToList();
            txtDistributor.ValueMember = "Id";
            txtDistributor.DisplayMember = "CariAdi";
            txtDistributor.SelectedIndex = -1;
        }

        private void YeniKayit()
        {
            if (secimId!=-1 || txtUkodu.Text=="")
            {
                return;
            }

            try
            {
                tblUrunler urn = new tblUrunler();
                urn.UrunAdi = txtUAdi.Text;
                urn.UrunGenelNo = n.UrunGenelKodu();
                urn.UrunKodu = txtUkodu.Text;
                urn.AlisFiyat = decimal.Parse(txtUAlisFiyat.Text);
                urn.SatisFiyat = decimal.Parse(txtUSatisFiyat.Text);
                urn.DistributorId = (int)txtDistributor.SelectedValue;
                urn.KutuIcerik = txtUkutuIcerik.Text;
                urn.UrunAciklama = txtUAciklama.Text;
                urn.SaveDate=DateTime.Now;
                urn.SaveUserId = 1;
                urn.isActive = true;

                erp.tblUrunler.Add(urn);
                erp.SaveChanges();
                MessageBox.Show("Kayit basarili");
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

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
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
            if (Application.OpenForms["frmUrunlerListesi"] == null)
            {
                frmUrunlerListesi frm = new frmUrunlerListesi();
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

        private tblUrunler urunler;
        public void Ac(int id)
        {
            secimId = id;
            urunler = erp.tblUrunler.Find(secimId);
            try
            {
                tblUrunler urn = urunler;
                txtDistributor.Text = urn.tblCariler.CariAdi;
                txtKayitBul.Text = urn.UrunGenelNo;
                txtUkodu.Text = urn.UrunKodu;
                txtUAciklama.Text = urn.UrunAciklama;
                txtUAdi.Text = urn.UrunAdi;
                txtUAlisFiyat.Text = urn.AlisFiyat.ToString();
                txtUSatisFiyat.Text = urn.SatisFiyat.ToString();
                txtUkutuIcerik.Text = urn.KutuIcerik;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        void Guncelle()
        {
            if (secimId==-1)
            {
                return;
            }

            try
            {
                tblUrunler urn = urunler;
                urn.UrunAdi = txtUAdi.Text;
                urn.UrunGenelNo = txtKayitBul.Text;
                urn.UrunKodu = txtUkodu.Text;
                urn.AlisFiyat = decimal.Parse(txtUAlisFiyat.Text);
                urn.SatisFiyat = decimal.Parse(txtUSatisFiyat.Text);
                urn.DistributorId = (int)txtDistributor.SelectedValue;
                urn.KutuIcerik = txtUkutuIcerik.Text;
                urn.UrunAciklama = txtUAciklama.Text;
                urn.UpdateDate = DateTime.Now;
                urn.UpdateUserId = 1;
                
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                tblUrunler hst = urunler;
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
    }
}
