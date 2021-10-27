namespace Discussions.Models
{
    public class Fil : Message
    {
        public int CommunauteId { get; set; }
        public virtual Communaute Communaute {get;set;}
    }
}
