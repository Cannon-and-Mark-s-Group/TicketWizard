using Microsoft.EntityFrameworkCore;

namespace TicketWizard.Data
{
    public class TicketWizardDbContext : DbContext
    {
        public TicketWizardDbContext(DbContextOptions<TicketWizardDbContext> options) : base(options)
        {

        }


  
    }
}
