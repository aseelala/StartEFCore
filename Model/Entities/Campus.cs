using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    [Table("Campussen")]
    public class Campus
    {
        // ----------- // Constructor // -----------
        public Campus()
        {
            Docenten = new List<Docent>();
        }
        // ---------- // Properties // ---------- 
      //  [Key]
      //  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CampusId { get; set; }

     //   [Required] 
     //   [Column("CampusNaam")]
        public string Naam { get; set; }

        public string Straat { get; set; }
        public string Huisnummer { get; set; }
        public string Postcode { get; set; }

      //  [StringLength(50)]
        public string Gemeente { get; set; }

       // [NotMapped]// niet in DB
        public string Commentaar { get; set; }
        // --------------------- // Navigation Properties // -----------
        public virtual ICollection<Docent> Docenten { get; set; }
    }
}