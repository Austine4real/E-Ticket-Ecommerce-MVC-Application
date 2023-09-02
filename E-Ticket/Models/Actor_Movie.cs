namespace E_Ticket.Models
{
    public class Actor_Movie
    {
        //many-to-many Relationship
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }

        
    }
}
