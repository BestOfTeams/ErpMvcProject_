using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.Entity
{
    [Table("tblProducts")]
    public   class Products:BaseClass
    {
        [StringLength(50)]
        public string PGeneralNumber { get; set; }
        [StringLength(50)]
        public string PCode { get; set; }
        [StringLength(50)]
        public string PName { get; set; }
     
        public string PDiscription { get; set; }
        public string BoxContents { get; set; }
        public decimal BuyingPrice { get; set; }       
        public decimal SalePrice { get; set; }
        public decimal ExposureTime { get; set; }

        //cariler ile bir e çok ilişki burası çoklu kısım
      // public int cDispId { get; set; }
        
        public virtual Current cDispId { get; set; }

    }
}
