using IEA_ErpProject102_Main.Entitiy;
using IEA_ErpProject102_Main.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject102_Main.BilgiGirisIslemleri.Inheratances
{
  public  class FormUst : Form
    {
       public ErpProject102Entities erp = new ErpProject102Entities();
       public Numaralar n = new Numaralar();
       public int secimId = -1;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormUst
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FormUst";
            this.Load += new System.EventHandler(this.FormUst_Load);
            this.ResumeLayout(false);

        }

        private void FormUst_Load(object sender, EventArgs e)
        {

        }
    }
}
