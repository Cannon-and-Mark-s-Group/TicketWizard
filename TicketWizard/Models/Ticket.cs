using System.ComponentModel.DataAnnotations.Schema;

namespace TicketWizard.Models
{
    public enum Priority
    {
        Low, Mid, High
    }

    [Table("Ticket", Schema = "dbo")]
    public class Ticket
    {
        public int TicketId { get; set; }
        public int TechId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public String Location { get; set; }
        public Priority Priority { get; set; }
        public DateTime EndDate { get; set; }
        public string Notes { get; set; }

        public virtual Tech Tech { get; set; }

    }
}
