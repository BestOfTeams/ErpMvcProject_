using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.Entity
{
 public   class Products:BaseClass
    {
        public string PGeneralNumber { get; set; }
        public string PCode { get; set; }
        public string PName { get; set; }
        public string PDiscription { get; set; }
        public string BoxContents { get; set; }
        public decimal BuyingPrice { get; set; }       
        public decimal SalePrice { get; set; }
        public decimal ExposureTime { get; set; }
       
      

    }
}
