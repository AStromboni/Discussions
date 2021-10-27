using Discussions.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Discussions.Models
{
    public class AbonnementCommunaute
    {
        
        public string DiscussionsUserId { get; set; }

        public int CommunauteId { get; set; }

        public virtual DiscussionsUser DiscussionsUser { get; set; }
        public virtual Communaute Communaute { get; set; }
    }
}
