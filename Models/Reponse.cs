namespace Discussions.Models
{
    public class Reponse:Message
    {
        public int MessageOrigineId { get; set; }
        public virtual Message MessageOrigine { get; set; }
    }
}
