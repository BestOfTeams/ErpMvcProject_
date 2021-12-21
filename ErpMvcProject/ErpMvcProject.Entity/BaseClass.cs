using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.Entity
{
  public  class BaseClass
    {
        public int Id { get; set; }
        public DateTime SaveDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int SaveUserId { get; set; }
        public int UpdateUserId { get; set; }
        public bool isActive { get; set; }
        
    }
}
