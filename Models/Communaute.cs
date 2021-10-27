using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Discussions.Models
{


    public class Communaute
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommunauteId { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime CreationDate { get; set; }
        public virtual ICollection<AbonnementCommunaute> Abonnes { get; set; }
        public virtual ICollection<Fil> Fils { get; set; }


    }
}
