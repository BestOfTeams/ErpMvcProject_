using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.Entity
{
    [Table("tblDepartments")]
    public  class Departments
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(50)]
        public string DepName { get; set; }
        public bool isActive { get; set; }

        //carigruplar ile bire cok ilişki burası coklu kısım
       
       
        public int CurrentGroupsId { get; set; }

        [ForeignKey("CurrentGroupsId")]
        public virtual CurrentGroups CurrentGroups { get; set; }

    }
}
