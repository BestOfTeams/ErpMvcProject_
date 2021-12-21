using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.Entity
{
    class StockEntryLower:BaseStock
    {
        public string GeneralNumber { get; set; }
        public string OrderNumber { get; set; }
        public int Count { get; set; }
        public string Note { get; set; }
        public string BuyingPrice { get; set; }
    }        
}
