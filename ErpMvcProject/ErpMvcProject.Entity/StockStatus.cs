using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.Entity
{
  public  class StockStatus:BaseStock
    {
        public string StockCode { get; set; }
        public int StockCount { get; set; }
        public int ShelfCount { get; set; }
        public int BranchCount { get; set; }
        public int ConsigneeCount { get; set; }
    }
}
