using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.Entity
{
    [Table("tblCurrents")]
    public class Current : BaseClass
    {
        [StringLength(10)]
        public string cCode { get; set; }
        public int cTypeId { get; set; }
        [StringLength(50)]
        public string cName { get; set; }
        [StringLength(50)]
        public string Title { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Address3 { get; set; }
        [StringLength(100)]
        public string TaxOffice { get; set; }

        [StringLength(11)]
        public string TcId { get; set; }
        [StringLength(20)]
        public string cPhone { get; set; }
        [StringLength(50)]
        public string cMail { get; set; }
        [StringLength(50)]
        public string sName1 { get; set; }
        [StringLength(50)]
        public string sName2 { get; set; }
        [StringLength(50)]
        public string sName3 { get; set; }
        [StringLength(50)]
        public string sDepartment1 { get; set; }
        [StringLength(50)]
        public string sDepartment2 { get; set; }
        [StringLength(50)]
        public string sDepartment3 { get; set; }

        [StringLength(50)]
        public string sMPhone1 { get; set; }
        [StringLength(50)]
        public string sMPhone2 { get; set; }
        [StringLength(50)]
        public string sMPhone3 { get; set; }
        [StringLength(50)]
        public string sPhone1 { get; set; }
        [StringLength(50)]
        public string sPhone2 { get; set; }
        [StringLength(50)]
        public string sPhone3 { get; set; }
        [StringLength(50)]
        public string sMail1 { get; set; }
        [StringLength(50)]
        public string sMail2 { get; set; }
        [StringLength(50)]
        public string sMail3 { get; set; }

        //employdetails ile bir e çok ilişki burası bir li kısım
        public virtual List<EmployeeDetails> EmployeeDetails { get; set; }

        //stokgirişust ile 
        public virtual List<StockEntryTop> StockEntryTops { get; set; }

        //carigrupları ile bir e çok ilişki burası çoklu kısım
        public int CurrentGroupsId { get; set; }
        [ForeignKey("CurrentGroupsId")]
        public virtual CurrentGroups CurrentGroups { get; set; }

        //ürünler ile bağlantı burası tekli taraf
        public virtual List<Products> Products { get; set; }


        //şehirler ile bire çok ilişki buraso coklu kısım

        public int CitiesId { get; set; }
        [ForeignKey("CitiesId")]
        public virtual Cities Cities { get; set; }
    }
}
