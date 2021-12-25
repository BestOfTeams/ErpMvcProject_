using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.Entity
{

    [Table("tblEmployeeDetails")]
    public class EmployeeDetails
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime? FirstDate { get; set; }
        public DateTime? EndDate { get; set; }

        //Current ile bir e çok iliki burası coklu kısım
        //  public int CurrentId { get; set; }
        
        public int CurrentId { get; set; }
        
        public virtual Current Current { get; set; }
    }
}
