
namespace IEA_ErpProject102_Main.BilgiGirisIslemleri.Personeler
{
    partial class FrmPersonelGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtHKoduBul = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtVnTc = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.txtPMail = new System.Windows.Forms.TextBox();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.lblHastaneKodu = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.BtnKayit = new System.Windows.Forms.Button();
            this.txtPUnvan = new System.Windows.Forms.ComboBox();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPTel = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPAdres1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPAdres2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPAdi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPTipi = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoktorCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPDept = new System.Windows.Forms.ComboBox();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.txtDurum = new System.Windows.Forms.CheckBox();
            this.txtBitisT = new System.Windows.Forms.DateTimePicker();
            this.txtGirisT = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPCep = new System.Windows.Forms.MaskedTextBox();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlOrta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = global::IEA_ErpProject102_Main.Properties.Resources.Sil64;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Location = new System.Drawing.Point(144, 11);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(40, 37);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtHKoduBul
            // 
            this.txtHKoduBul.Location = new System.Drawing.Point(99, 5);
            this.txtHKoduBul.Margin = new System.Windows.Forms.Padding(2);
            this.txtHKoduBul.Name = "txtHKoduBul";
            this.txtHKoduBul.Size = new System.Drawing.Size(240, 20);
            this.txtHKoduBul.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(20, 212);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 19);
            this.label15.TabIndex = 4;
            this.label15.Text = "Personel Tip :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVnTc
            // 
            this.txtVnTc.Location = new System.Drawing.Point(99, 143);
            this.txtVnTc.Margin = new System.Windows.Forms.Padding(2);
            this.txtVnTc.Mask = "00000000000";
            this.txtVnTc.Name = "txtVnTc";
            this.txtVnTc.Size = new System.Drawing.Size(76, 20);
            this.txtVnTc.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personel Adi :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personel Unvan :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSehir
            // 
            this.txtSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(99, 190);
            this.txtSehir.Margin = new System.Windows.Forms.Padding(2);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(134, 21);
            this.txtSehir.TabIndex = 3;
            // 
            // txtPMail
            // 
            this.txtPMail.Location = new System.Drawing.Point(99, 120);
            this.txtPMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtPMail.Name = "txtPMail";
            this.txtPMail.Size = new System.Drawing.Size(120, 20);
            this.txtPMail.TabIndex = 7;
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlUst.Controls.Add(this.lblHastaneKodu);
            this.pnlUst.Controls.Add(this.btnCikis);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.BtnKayit);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(774, 58);
            this.pnlUst.TabIndex = 10;
            // 
            // lblHastaneKodu
            // 
            this.lblHastaneKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHastaneKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaneKodu.Location = new System.Drawing.Point(346, 20);
            this.lblHastaneKodu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHastaneKodu.Name = "lblHastaneKodu";
            this.lblHastaneKodu.Size = new System.Drawing.Size(119, 27);
            this.lblHastaneKodu.TabIndex = 4;
            this.lblHastaneKodu.Text = "***";
            this.lblHastaneKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackgroundImage = global::IEA_ErpProject102_Main.Properties.Resources.exit_64;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(707, 6);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(2);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(56, 46);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::IEA_ErpProject102_Main.Properties.Resources.cop24x24;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(99, 10);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(40, 37);
            this.btnSil.TabIndex = 2;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::IEA_ErpProject102_Main.Properties.Resources.Update32x32;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(54, 10);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(40, 37);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // BtnKayit
            // 
            this.BtnKayit.BackgroundImage = global::IEA_ErpProject102_Main.Properties.Resources.Save_icon64x64;
            this.BtnKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKayit.Location = new System.Drawing.Point(9, 10);
            this.BtnKayit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnKayit.Name = "BtnKayit";
            this.BtnKayit.Size = new System.Drawing.Size(40, 37);
            this.BtnKayit.TabIndex = 0;
            this.BtnKayit.Tag = "";
            this.BtnKayit.UseVisualStyleBackColor = true;
            this.BtnKayit.Click += new System.EventHandler(this.BtnKayit_Click);
            // 
            // txtPUnvan
            // 
            this.txtPUnvan.FormattingEnabled = true;
            this.txtPUnvan.Location = new System.Drawing.Point(99, 28);
            this.txtPUnvan.Margin = new System.Windows.Forms.Padding(2);
            this.txtPUnvan.Name = "txtPUnvan";
            this.txtPUnvan.Size = new System.Drawing.Size(170, 21);
            this.txtPUnvan.TabIndex = 26;
            // 
            // pnlAlt
            // 
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 492);
            this.pnlAlt.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(774, 8);
            this.pnlAlt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(44, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tc No :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPTel
            // 
            this.txtPTel.Location = new System.Drawing.Point(99, 75);
            this.txtPTel.Margin = new System.Windows.Forms.Padding(2);
            this.txtPTel.Mask = "(999) 000-0000";
            this.txtPTel.Name = "txtPTel";
            this.txtPTel.Size = new System.Drawing.Size(89, 20);
            this.txtPTel.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(13, 98);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cep Telefonu :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPAdres1
            // 
            this.txtPAdres1.Location = new System.Drawing.Point(442, 5);
            this.txtPAdres1.Margin = new System.Windows.Forms.Padding(2);
            this.txtPAdres1.Multiline = true;
            this.txtPAdres1.Name = "txtPAdres1";
            this.txtPAdres1.Size = new System.Drawing.Size(312, 38);
            this.txtPAdres1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(363, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel Adres 1:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPAdres2
            // 
            this.txtPAdres2.Location = new System.Drawing.Point(442, 47);
            this.txtPAdres2.Margin = new System.Windows.Forms.Padding(2);
            this.txtPAdres2.Multiline = true;
            this.txtPAdres2.Name = "txtPAdres2";
            this.txtPAdres2.Size = new System.Drawing.Size(312, 38);
            this.txtPAdres2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(20, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Personel Tel :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPAdi
            // 
            this.txtPAdi.Location = new System.Drawing.Point(99, 52);
            this.txtPAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtPAdi.Name = "txtPAdi";
            this.txtPAdi.Size = new System.Drawing.Size(240, 20);
            this.txtPAdi.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(22, 121);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 19);
            this.label13.TabIndex = 4;
            this.label13.Text = "Personel Mail :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPTipi
            // 
            this.txtPTipi.FormattingEnabled = true;
            this.txtPTipi.Location = new System.Drawing.Point(99, 214);
            this.txtPTipi.Margin = new System.Windows.Forms.Padding(2);
            this.txtPTipi.Name = "txtPTipi";
            this.txtPTipi.Size = new System.Drawing.Size(134, 21);
            this.txtPTipi.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(20, 190);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 19);
            this.label14.TabIndex = 4;
            this.label14.Text = "Sehir :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(363, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "Personel Adres 2:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 312);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(774, 15);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // Liste
            // 
            this.Liste.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sira,
            this.CariKodu,
            this.CariAdi,
            this.CariTel,
            this.DoktorCep,
            this.CariMail,
            this.basTarih,
            this.bitTarih});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Liste.Location = new System.Drawing.Point(0, 327);
            this.Liste.Margin = new System.Windows.Forms.Padding(2);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 51;
            this.Liste.RowTemplate.Height = 24;
            this.Liste.Size = new System.Drawing.Size(774, 165);
            this.Liste.TabIndex = 12;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sira";
            this.Sira.MinimumWidth = 6;
            this.Sira.Name = "Sira";
            this.Sira.Width = 50;
            // 
            // CariKodu
            // 
            this.CariKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariKodu.HeaderText = "Personel Kodu";
            this.CariKodu.MinimumWidth = 6;
            this.CariKodu.Name = "CariKodu";
            this.CariKodu.Width = 93;
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Personel Adi";
            this.CariAdi.MinimumWidth = 6;
            this.CariAdi.Name = "CariAdi";
            // 
            // CariTel
            // 
            this.CariTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariTel.HeaderText = "Personel Telefonu";
            this.CariTel.MinimumWidth = 6;
            this.CariTel.Name = "CariTel";
            this.CariTel.Width = 108;
            // 
            // DoktorCep
            // 
            this.DoktorCep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DoktorCep.HeaderText = "Personel Gsm";
            this.DoktorCep.MinimumWidth = 6;
            this.DoktorCep.Name = "DoktorCep";
            this.DoktorCep.Width = 89;
            // 
            // CariMail
            // 
            this.CariMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariMail.HeaderText = "Personel Mail";
            this.CariMail.MinimumWidth = 6;
            this.CariMail.Name = "CariMail";
            this.CariMail.Width = 87;
            // 
            // basTarih
            // 
            this.basTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = "-";
            this.basTarih.DefaultCellStyle = dataGridViewCellStyle1;
            this.basTarih.HeaderText = "Baslangic Tarihi";
            this.basTarih.MinimumWidth = 6;
            this.basTarih.Name = "basTarih";
            this.basTarih.Width = 98;
            // 
            // bitTarih
            // 
            this.bitTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = "-";
            this.bitTarih.DefaultCellStyle = dataGridViewCellStyle2;
            this.bitTarih.HeaderText = "Bitis Tarihi";
            this.bitTarih.MinimumWidth = 6;
            this.bitTarih.Name = "bitTarih";
            this.bitTarih.Width = 74;
            // 
            // txtPDept
            // 
            this.txtPDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPDept.FormattingEnabled = true;
            this.txtPDept.Location = new System.Drawing.Point(99, 166);
            this.txtPDept.Margin = new System.Windows.Forms.Padding(2);
            this.txtPDept.Name = "txtPDept";
            this.txtPDept.Size = new System.Drawing.Size(134, 21);
            this.txtPDept.TabIndex = 11;
            // 
            // pnlOrta
            // 
            this.pnlOrta.Controls.Add(this.txtDurum);
            this.pnlOrta.Controls.Add(this.txtBitisT);
            this.pnlOrta.Controls.Add(this.txtGirisT);
            this.pnlOrta.Controls.Add(this.label5);
            this.pnlOrta.Controls.Add(this.label9);
            this.pnlOrta.Controls.Add(this.txtPUnvan);
            this.pnlOrta.Controls.Add(this.txtHKoduBul);
            this.pnlOrta.Controls.Add(this.label15);
            this.pnlOrta.Controls.Add(this.txtVnTc);
            this.pnlOrta.Controls.Add(this.label1);
            this.pnlOrta.Controls.Add(this.label2);
            this.pnlOrta.Controls.Add(this.txtSehir);
            this.pnlOrta.Controls.Add(this.txtPMail);
            this.pnlOrta.Controls.Add(this.label6);
            this.pnlOrta.Controls.Add(this.txtPTel);
            this.pnlOrta.Controls.Add(this.label10);
            this.pnlOrta.Controls.Add(this.txtPAdres1);
            this.pnlOrta.Controls.Add(this.label3);
            this.pnlOrta.Controls.Add(this.txtPAdres2);
            this.pnlOrta.Controls.Add(this.label7);
            this.pnlOrta.Controls.Add(this.txtPAdi);
            this.pnlOrta.Controls.Add(this.label13);
            this.pnlOrta.Controls.Add(this.txtPTipi);
            this.pnlOrta.Controls.Add(this.label14);
            this.pnlOrta.Controls.Add(this.label4);
            this.pnlOrta.Controls.Add(this.label8);
            this.pnlOrta.Controls.Add(this.txtPCep);
            this.pnlOrta.Controls.Add(this.txtPDept);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(0, 58);
            this.pnlOrta.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(774, 434);
            this.pnlOrta.TabIndex = 14;
            // 
            // txtDurum
            // 
            this.txtDurum.AutoSize = true;
            this.txtDurum.Location = new System.Drawing.Point(597, 98);
            this.txtDurum.Margin = new System.Windows.Forms.Padding(2);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(123, 17);
            this.txtDurum.TabIndex = 30;
            this.txtDurum.Text = "Is Bitis tarihi eklensin";
            this.txtDurum.UseVisualStyleBackColor = true;
            this.txtDurum.Visible = false;
            this.txtDurum.CheckedChanged += new System.EventHandler(this.txtDurum_CheckedChanged);
            // 
            // txtBitisT
            // 
            this.txtBitisT.Location = new System.Drawing.Point(442, 122);
            this.txtBitisT.Margin = new System.Windows.Forms.Padding(2);
            this.txtBitisT.Name = "txtBitisT";
            this.txtBitisT.Size = new System.Drawing.Size(151, 20);
            this.txtBitisT.TabIndex = 29;
            this.txtBitisT.Visible = false;
            // 
            // txtGirisT
            // 
            this.txtGirisT.Location = new System.Drawing.Point(442, 98);
            this.txtGirisT.Margin = new System.Windows.Forms.Padding(2);
            this.txtGirisT.Name = "txtGirisT";
            this.txtGirisT.Size = new System.Drawing.Size(151, 20);
            this.txtGirisT.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(310, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Bitis Tarihi :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Visible = false;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(306, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 19);
            this.label9.TabIndex = 28;
            this.label9.Text = "Baslangic Tarihi :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(11, 166);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Departmani :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPCep
            // 
            this.txtPCep.Location = new System.Drawing.Point(99, 98);
            this.txtPCep.Margin = new System.Windows.Forms.Padding(2);
            this.txtPCep.Mask = "(999) 000-0000";
            this.txtPCep.Name = "txtPCep";
            this.txtPCep.Size = new System.Drawing.Size(89, 20);
            this.txtPCep.TabIndex = 13;
            // 
            // FrmPersonelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 500);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.pnlAlt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPersonelGiris";
            this.Text = "FrmPersonelGiris";
            this.Load += new System.EventHandler(this.FrmPersonelGiris_Load);
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlOrta.ResumeLayout(false);
            this.pnlOrta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox txtHKoduBul;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtVnTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.TextBox txtPMail;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Label lblHastaneKodu;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button BtnKayit;
        private System.Windows.Forms.ComboBox txtPUnvan;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtPTel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPAdres1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPAdres2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPAdi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox txtPTipi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.ComboBox txtPDept;
        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtPCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoktorCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn basTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitTarih;
        private System.Windows.Forms.CheckBox txtDurum;
        private System.Windows.Forms.DateTimePicker txtBitisT;
        private System.Windows.Forms.DateTimePicker txtGirisT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
    }
}