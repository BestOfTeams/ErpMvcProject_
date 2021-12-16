using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.Entity
{
    [Table("tblCurrentGroups")]
    public class CurrentGroups
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(50)]
        public string gName { get; set; }
        public bool isActive { get; set; }

        //stok giriş üst ile bağlantı burası tekli taraf
        public virtual List<StockEntryTop> StockEntryTops { get; set; }
        //departmans ile bağlantı burası tekli taraf
        public virtual List<Departments> Departments { get; set; }

        //cariler ile bir e çok ilişki burası tekli taraf
        public virtual List<Current> Currents { get; set; }

    }
}
