using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2.SellingView
{
    public class ctblSellingDetailView
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tblSellingDetailID { get; set; }
        [Key]
        [Column(TypeName = "Varchar")]
        [StringLength(5)]
        public string Invoice { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string ItemCode { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string ItemName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(5)]
        public string ItemPrice { get; set; }
        public decimal SubTotal { get; set; }
    }
}
