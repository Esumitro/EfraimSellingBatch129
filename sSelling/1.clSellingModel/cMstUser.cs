using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.clSellingModel
{
    public class MstUser : SellingData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string Username { get; set; }
        [Required]
        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string Password { get; set; }
        public bool Active { get; set; }
        [Required]
        [Column(TypeName = "Varchar")]
        [StringLength(5)]
        public string OfficerCode { get; set; }
        public string OfficerName { get; set; }
    }
}
