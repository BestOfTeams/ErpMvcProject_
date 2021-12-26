using ErpMvcProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.BusinessLayer
{
 public class StockViewModel
    {
        public StockEntryTop stockEntryTop { get; set; }
        public StockEntryLower stockEntryLower { get; set; }
        public StockStatus stockStatus { get; set; }
    }
}
