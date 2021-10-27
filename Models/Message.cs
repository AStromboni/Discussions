using Discussions.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Discussions.Models
{
    public abstract class Message
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MessageId { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Content { get; set; }

        public string DiscussionsUserId { get; set; }

        public virtual DiscussionsUser Author { get; set; }

        public DateTime CreatedOn { get; set; }

        public virtual ICollection<Reponse> Reponse { get; set; }
    }
}
