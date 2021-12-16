using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.Entity
{
    [Table("tblStockStatus")]
    public  class StockStatus:BaseStock
    {
        [StringLength(50)]
        public string StockCode { get; set; }
        public int StockCount { get; set; }
        public int ShelfCount { get; set; }
        public int BranchCount { get; set; }
        public int ConsigneeCount { get; set; }
    }
}
