namespace TicketWizard.Models
{
    public class Tech
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }    

        
    }
}
