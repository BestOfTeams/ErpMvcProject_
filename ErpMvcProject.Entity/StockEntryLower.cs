using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.Entity
{
    [Table("tblStockEntyLowers")]
    public class StockEntryLower:BaseStock
    {
        
        public int GeneralNumber { get; set; }
      
        public int OrderNumber { get; set; }
        public int Count { get; set; }
    
        public string Note { get; set; }
        
        public decimal BuyingPrice { get; set; }
    }        
}
