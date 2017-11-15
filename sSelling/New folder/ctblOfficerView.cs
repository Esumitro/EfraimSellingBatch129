using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2.SellingView
{
    public class tblOfficerView
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tblOfficerID { get; set; }
        [Key]
        [Column(TypeName = "Varchar")]
        [StringLength(5)]
        [Display(Name="Kode Petugas")]
        public string OfficerCode { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(5)]
        [Display(Name="Nama Petugas")]
        public string OfficerName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        [Display(Name="Sandi Petugas")]
        public string OfficerPassword { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        [Display(Name="Status Petugas")]
        public string OfficerStatus { get; set; }
    }
}
