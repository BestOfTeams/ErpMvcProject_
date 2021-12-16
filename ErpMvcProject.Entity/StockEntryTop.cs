using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.Entity
{
    [Table("tblStockEntyTops")]
    public class StockEntryTop : BaseClass
    {

        public int GeneralNumber { get; set; }
        public int EntryType { get; set; }
        [StringLength(50)]
        public string InvoiceNumber { get; set; }
       
        public string Description { get; set; }
        public DateTime InvoiceDate { get; set; }

        //cariler ile bire çok ilişkide bura çoklu kısım
      //  public int cId { get; set; }
        public virtual Current cId { get; set; }

        //carigruoplari ile burası çoklu kısım
       // public int cGroupId { get; set; }
        public virtual CurrentGroups cGroupId { get; set; }


        

    }
}
