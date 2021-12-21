using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.Entity
{
    public class BaseStock
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Lot { get; set; }
        public string ProductCode { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiryDate { get; set; }

    }
}
