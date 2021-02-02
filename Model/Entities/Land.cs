using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Entities
{
   public class Land
    {
        public Land()
        {
            Docenten = new List<Docent>();
        }
     //   [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string LandCode { get; set; }
        public string Naam { get; set; } 

        // --------------------- // Navigation Properties // --------------------- 
        public virtual ICollection<Docent> Docenten { get; set; }
    }
}
