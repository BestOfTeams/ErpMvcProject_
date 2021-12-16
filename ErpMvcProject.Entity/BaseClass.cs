using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.Entity
{
  public  class BaseClass
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime SaveDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public int SaveUserId { get; set; }
        public int UpdateUserId { get; set; }
        public bool isActive { get; set; }
        
    }
}
