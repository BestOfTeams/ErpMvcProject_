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
using IEA_ErpProject102_Main.BilgiGirisIslemleri.Hastaneler;
using IEA_ErpProject102_Main.BilgiGirisIslemleri.Inheratances;
using IEA_ErpProject102_Main.Entitiy;
using IEA_ErpProject102_Main.Fonksiyonlar;
using IEA_ErpProject102_Main.Properties;

namespace IEA_ErpProject102_Main.BilgiGirisIslemleri.Doktorlar
{
    public partial class frmDoktorGirisEkrani : FormUst
    {
      

        public frmDoktorGirisEkrani()
        {
            InitializeComponent();
        }

        private void frmDoktorGirisEkrani_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblCariler
                where s.isActive == true
                where s.CariGrupId == 2
                select new
                {
                    id = s.Id,
                    dkodu = s.CariKodu,
                    dadi = s.CariAdi,
                    dtel = s.CariTel,
                    dmail = s.CariMail,
                    dyetcep = s.YetkiliCep1
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
                i++;
                sira++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblHastaneKodu.Text = n.CariKoduDoktor();

        }
        private void ComboDoldur()
        {
            txtDokUnvan.DataSource = Enum.GetValues(typeof(enumDoktorUnvanlar));

            var dep1 = erp.tblDepartmanlar.Where(x => x.GrupId == 2).ToList();
            
            var seh = erp.tblSehirler.ToList();

            txtSehir.DataSource = seh;
            txtSehir.ValueMember = "id";
            txtSehir.DisplayMember = "sehir";
            txtSehir.SelectedIndex = -1;

            txtDrDepartman.DataSource = dep1;
            txtDrDepartman.ValueMember = "Id";
            txtDrDepartman.DisplayMember = "DeptAdi";
            txtDrDepartman.SelectedIndex = -1;

        }
        private void YeniKayit()
        {
            string hkodu = n.CariKoduDoktor();
            try
            {
                if (txtDrAdi.Text == "")
                {
                    return;
                }
                if (secimId == -1)
                {
                    tblCariler hst = new tblCariler();
                    hst.isActive = true;
                    hst.CariAdi = txtDrAdi.Text;
                    hst.CariMail = txtDrMail.Text;
                    hst.CariTel = txtDrTel.Text;
                    
                    hst.YetkiliDep1 = txtDrDepartman.Text;
                    
                    
                    hst.YetkiliCep1 = txtDrCep.Text;
                    
                    
                    hst.Adres1 = txtDrHastAdres.Text;
                    hst.Adres2 = txtDrMuaAdres.Text;
                    hst.CariGrupId = 2;
                    hst.CariTipId = 1;
                    hst.CariUnvan = txtDokUnvan.Text;
                    hst.VDairesi = txtVergiD.Text;
                    hst.VnoTcno = txtVnTc.Text;
                    if (txtSehir.SelectedValue!=null)
                    {
                        hst.SehirId = (int)txtSehir.SelectedValue;
                    }
                    //txtSehir.SelectedValue!=null ? (int) txtSehir.SelectedValue:-1;
                    //erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;

                    hst.SaveDate = DateTime.Now;
                    hst.SaveUserId = 1;
                    hst.CariKodu = hkodu;

                    erp.tblCariler.Add(hst);
                    erp.SaveChanges();
                    MessageBox.Show(@"Kayit Basarili");

                    Temizle();
                    Listele();
                }
                else
                {
                    MessageBox.Show(@"Bu kayit daha once sahiplendirilmis. Kendine baska bir kayit bul...");
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
                hst.CariAdi = txtDrAdi.Text;
                hst.CariMail = txtDrMail.Text;
                hst.CariTel = txtDrTel.Text;
                
                hst.YetkiliDep1 = txtDrDepartman.Text;
                
                hst.YetkiliCep1 = txtDrCep.Text;
                
                hst.Adres1 = txtDrHastAdres.Text;
                hst.Adres2 = txtDrMuaAdres.Text;
                hst.CariTipId = 1;
                hst.CariUnvan = txtDokUnvan.Text;
                hst.VDairesi = txtVergiD.Text;
                hst.VnoTcno = txtVnTc.Text;
                hst.SehirId = (int?)txtSehir.SelectedValue ?? -1;
                hst.UpdateDate = DateTime.Now;
                hst.UpdateUserId = 1;
                hst.CariKodu = lblHastaneKodu.Text;

                erp.SaveChanges();
                MessageBox.Show(@"Guncelleme Basarili");

                Temizle();
                Listele();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
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
            txtSehir.SelectedIndex = -1;
        }
        public void Ac(int i)
        {
            secimId = i;
            try
            {
                tblCariler hst = erp.tblCariler.Find(i);
                txtDrAdi.Text = hst.CariAdi;
                txtDrMail.Text = hst.CariMail;
                txtDrTel.Text = hst.CariTel;
                
                txtDrDepartman.Text = hst.YetkiliDep1;
                
                txtDrCep.Text = hst.YetkiliCep1;
                
                txtDrHastAdres.Text = hst.Adres1;
                txtDrMuaAdres.Text = hst.Adres2;
                txtDokUnvan.Text = hst.CariUnvan;
                txtVergiD.Text = hst.VDairesi;
                txtVnTc.Text = hst.VnoTcno;
                txtSehir.Text = hst.tblSehirler==null ? "" : hst.tblSehirler.sehir;
                lblHastaneKodu.Text = hst.CariKodu;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25, txtHKoduBul.ClientSize.Height + 0);
            btn.Location = new Point(txtHKoduBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.Image = Resources.arrow_1176;
            SendMessage(txtHKoduBul.Handle, 0xd3, (IntPtr)2, (IntPtr)(btn.Width << 16));
            txtHKoduBul.Controls.Add(btn);

            base.OnLoad(e);
            btn.Click += btn_Click;
        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private void btn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmDoktorlarListesi"] == null)
            {
                frmDoktorlarListesi frm = new frmDoktorlarListesi();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            SendToBack();
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
                MessageBox.Show(@"Silme basarili");
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

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }
    }
}
