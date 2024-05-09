using System.ComponentModel.DataAnnotations.Schema;

namespace TicketWizard.Models
{
    [Table("Tech", Schema = "dbo")]
    public class Tech
    {
        public int TechId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        

        public virtual ICollection<Ticket> Tickets { get; set; }
    
    }
}