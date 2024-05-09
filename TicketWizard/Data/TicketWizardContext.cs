using Microsoft.EntityFrameworkCore;
using TicketWizard.Models;

namespace TicketWizard.Data
{
    public class TicketWizardContext : DbContext
    {
        public TicketWizardContext (DbContextOptions<TicketWizardContext> options) 
            : base(options)
        {
        
        }

        public DbSet<Ticket> RequestTickets { get; set; } = default!;

        public DbSet<Tech> Techs { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Ticket>()
                .HasKey(t => t.TicketId);

            modelBuilder.Entity<Tech>()
               .HasKey(t => t.TechId);
        }

    }
}
