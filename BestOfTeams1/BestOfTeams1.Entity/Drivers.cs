using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOfTeams1.Entity
{
    [Table("tblDrivers")]
    public  class Drivers
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(30), Required]
        public string dName { get; set; }
        [StringLength(30), Required]
        public string dSurname { get; set; }
        [Required] 
        public int dAge { get; set; }
        public virtual Buses Buses{ get; set; }
       

    }
}
