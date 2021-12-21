using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.Entity
{
    [Table("tblCities")]
    public class Cities
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        //currents ile bir e cok ilişki burası tekli kısım
        public virtual List<Current> Currents { get; set; }
       
    }
}
