namespace TicketWizard.Models
{

    public enum Priority
    { 
    Low, Medium, High
    };

    public class Ticket
    {
        public int TicketId { get; set; } 
        public int TechID { get; set; } 
        public string Description { get; set; } 
        public DateTime CreatedDate { get; set; }   
        public string Location { get; set; }    
        public Priority priority { get; set; }
        public DateTime EndDate { get; set; }
        public string Notes { get; set; }

        public virtual Tech Tech { get; set; }
    }
}
