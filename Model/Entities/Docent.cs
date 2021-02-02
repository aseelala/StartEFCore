using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    [Table("Docenten")]
    public partial class Docent 
    {
        // ---------- // Properties // ---------- 
      //  [Key]
        public int DocentId { get; set; }
      //  [Required]
      //  [MaxLength(20)]
        public string Voornaam { get; set; }

     //   [Required]
     //   [MaxLength(30)]
        public string Familienaam { get; set; }

     //   [Column("Maandwedde", TypeName = "decimal(18,4)")]
        public decimal Wedde { get; set; }
     //   [Column(TypeName = "date")]
        public DateTime InDienst { get; set; } 
        public bool? HeeftRijbewijs { get; set; }

    //    [ForeignKey("Land")]
        public string LandCode { get; set; }

        [ForeignKey("Campus")]
        public int CampusId { get; set; }
        // --------------------- // Navigation properties // 
        public virtual Campus Campus { get; set; }
        public virtual Land Land { get; set; }
    } 
}