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
using IEA_ErpProject102_Main.BilgiGirisIslemleri.Firmalar;
using IEA_ErpProject102_Main.BilgiGirisIslemleri.Hastaneler;
using IEA_ErpProject102_Main.BilgiGirisIslemleri.Personeler;
using IEA_ErpProject102_Main.DepoIslemleri.StokIslemleri;
using IEA_ErpProject102_Main.Urun_Islemleri;

namespace IEA_ErpProject102_Main
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            MenuOlustur();
        }

        private void MenuOlustur()
        {
            #region Bilgi Giris Islemleri

            tvBilgiGirisIslemleri.Nodes.Add("Hastaneler");//root elemani
            tvBilgiGirisIslemleri.Nodes[0].Nodes.Add("Hastane Bilgi Giris Ekrani");//Child
            tvBilgiGirisIslemleri.Nodes[0].Nodes.Add("Hastaneler Listesi");//Child

            tvBilgiGirisIslemleri.Nodes.Add("Doktorlar");//root elemani
            tvBilgiGirisIslemleri.Nodes[1].Nodes.Add("Doktor Bilgi Giris Ekrani");//Child
            tvBilgiGirisIslemleri.Nodes[1].Nodes.Add("Doktorlar Listesi");//Child

            tvBilgiGirisIslemleri.Nodes.Add("Firmalar");//root elemani
            tvBilgiGirisIslemleri.Nodes[2].Nodes.Add("Firma Bilgi Giris Ekrani");//Child
            tvBilgiGirisIslemleri.Nodes[2].Nodes.Add("Firmalar Listesi");//Child


            tvBilgiGirisIslemleri.Nodes.Add("Personeller");//root elemani
            tvBilgiGirisIslemleri.Nodes[3].Nodes.Add("Personel Bilgi Giris Ekrani");//Child
            tvBilgiGirisIslemleri.Nodes[3].Nodes.Add("Personeller Listesi");//Child
            #endregion

            #region Urun Islemleri
            tvUrunIslemleri.Nodes.Add("Urunler");//root elemani
            tvUrunIslemleri.Nodes[0].Nodes.Add("Urun Giris Ekrani");//Child
            tvUrunIslemleri.Nodes[0].Nodes.Add("Urunler Listesi");//Child
            #endregion

            #region DepoIslemleri
            tvDepoIslemleri.Nodes.Add("Depo Islemleri");
            tvDepoIslemleri.Nodes[0].Nodes.Add("Depo Stok Durum");
            tvDepoIslemleri.Nodes[0].Nodes.Add("Depo Stok Giris");
            tvDepoIslemleri.Nodes[0].Nodes[1].Nodes.Add("Stok Giris");
            tvDepoIslemleri.Nodes[0].Nodes[1].Nodes.Add("Stok Giris Listesi");
            tvDepoIslemleri.Nodes[0].Nodes.Add("Depo Sevkiyat");
            #endregion
        }

        private void btnBilgiGiris_Click(object sender, EventArgs e)
        {
            lblMenuText.Text = btnBilgiGiris.Text;
            TvGorunum();
            tvBilgiGirisIslemleri.Visible = true;
        }

        private void TvGorunum()
        {
            tvBilgiGirisIslemleri.Visible = false;
            tvUrunIslemleri.Visible = false;
            tvDepoIslemleri.Visible = false;
            tv4.Visible = false;
            tv5.Visible = false;
            tv6.Visible = false;
            tv7.Visible = false;
            tv8.Visible = false;
            tv9.Visible = false;
            tv10.Visible = false;
            tv11.Visible = false;
            tv12.Visible = false;
        }

        private void tvBilgiGirisIslemleri_DoubleClick(object sender, EventArgs e)
        {
            string isim = "";
            if (tvBilgiGirisIslemleri.SelectedNode!=null)
            {
                isim = tvBilgiGirisIslemleri.SelectedNode.Text;
            }


            //string isim = tvBilgiGirisIslemleri.SelectedNode!=null ? tvBilgiGirisIslemleri.SelectedNode.Text : "";

            if (isim== "Hastane Bilgi Giris Ekrani" && Application.OpenForms["frmHastaneGirisEkrani"]==null)
            {
                FrmHastaneGirisEkrani frm = new FrmHastaneGirisEkrani();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }else if (isim == "Hastaneler Listesi" && Application.OpenForms["frmHastanelerListesi"] ==null)
            {
                frmHastanelerListesi frm = new frmHastanelerListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Doktor Bilgi Giris Ekrani" && Application.OpenForms["frmDoktorGirisEkrani"] == null)
            {
                frmDoktorGirisEkrani frm = new frmDoktorGirisEkrani();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Doktorlar Listesi" && Application.OpenForms["frmDoktorlarListesi"] == null)
            {
                frmDoktorlarListesi frm = new frmDoktorlarListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Personel Bilgi Giris Ekrani" && Application.OpenForms["FrmPersonelGiris"] == null)
            {
                FrmPersonelGiris frm = new FrmPersonelGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Personeller Listesi" && Application.OpenForms["FrmPersonellerListesi"] == null)
            {
                FrmPersonellerListesi frm = new FrmPersonellerListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Firma Bilgi Giris Ekrani" && Application.OpenForms["frmFirmaGiris"] == null)
            {
                frmFirmaGiris frm = new frmFirmaGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Firmalar Listesi" && Application.OpenForms["frmFirmalarListesi"] == null)
            {
                frmFirmalarListesi frm = new frmFirmalarListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
        }

        private void btnUrunGiris_Click(object sender, EventArgs e)
        {
            lblMenuText.Text = btnBilgiGiris.Text;
            TvGorunum();
            tvUrunIslemleri.Visible = true;
        }

        private void tvUrunIslemleri_DoubleClick(object sender, EventArgs e)
        {
            string isim = "";
            if (tvUrunIslemleri.SelectedNode != null)
            {
                isim = tvUrunIslemleri.SelectedNode.Text;
            }
            if (isim == "Urun Giris Ekrani" && Application.OpenForms["frmUrunGiris"] == null)
            {
                frmUrunGiris frm = new frmUrunGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }else if (isim == "Urunler Listesi" && Application.OpenForms["frmUrunlerListesi"] == null)
            {
                frmUrunlerListesi frm = new frmUrunlerListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
        }

        private void tvDepoIslemleri_DoubleClick(object sender, EventArgs e)
        {
            string isim = "";
            if (tvDepoIslemleri.SelectedNode != null)
            {
                isim = tvDepoIslemleri.SelectedNode.Text;
            }
            if (isim == "Stok Giris Listesi" && Application.OpenForms["frmStokListesi"] == null)
            {
                frmStokListesi frm = new frmStokListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
           else if (isim == "Stok Giris" && Application.OpenForms["frmStokGiris"] == null)
            {
                frmStokGiris frm = new frmStokGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
        }

        private void btnDepoIslemleri_Click(object sender, EventArgs e)
        {
            lblMenuText.Text = btnDepoIslemleri.Text;
            TvGorunum();
            tvDepoIslemleri.Visible = true;
        }
    }
}
