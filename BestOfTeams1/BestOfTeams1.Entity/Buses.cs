using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOfTeams1.Entity
{
    [Table("tblBuses")]
  public  class Buses
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(20),Required]
        public string bNumberPlate { get; set; }
        [StringLength(6), Required]
        public string bWay { get; set; }
        public virtual List<Drivers> Drivers { get; set; }

        public  Buses()
        {
            Drivers=new List<Drivers>();
        }
    }
}
