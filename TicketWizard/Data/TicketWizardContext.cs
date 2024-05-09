using Microsoft.EntityFrameworkCore;
using TicketWizard.Models;

namespace TicketWizard.Data
{
    public class TicketWizardContext : DbContext
    {
        public TicketWizardContext (DbContextOptions<TicketWizardContext> options) : base(options)
        {
        
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Tech> Techs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {

            modelBuilder.Entity<Ticket>().HasData(

      new Ticket
      {
          Description = "Broken Computer",
          CreatedDate = DateTime.Parse("2024-05-09 10:15:00"),
          Location = "UP 207",
          priority = Priority.Low,
          EndDate = DateTime.Parse("2024-05-11"),
          Notes = "Computer won't start up"
      },
      new Ticket
      {
          Description = "Network Connectivity Issue",
          CreatedDate = DateTime.Parse("2024-05-08 13:45:00"),
          Location = "Server Room",
          priority = Priority.Medium,
          EndDate = DateTime.Parse("2024-05-10"),
          Notes = "Unable to connect to the network"
      },
      new Ticket
      {
          Description = "Printer Jam",
          CreatedDate = DateTime.Parse("2024-05-07 09:30:00"),
          Location = "Office 102",
          priority = Priority.High,
          EndDate = DateTime.Parse("2024-05-09"),
          Notes = "Paper stuck in the printer"
      },
      new Ticket
      {
          Description = "Software Installation Issue",
          CreatedDate = DateTime.Parse("2024-05-06 14:20:00"),
          Location = "Lab 305",
          priority = Priority.Medium,
          EndDate = DateTime.Parse("2024-05-08"),
          Notes = "Error during installation process"
      },
      new Ticket
      {
          Description = "Email Access Problem",
          CreatedDate = DateTime.Parse("2024-05-05 11:10:00"),
          Location = "Office 201",
          priority = Priority.Low,
          EndDate = DateTime.Parse("2024-05-07"),
          Notes = "Unable to access emails"
      },
      new Ticket
      {
          Description = "Projector Not Working",
          CreatedDate = DateTime.Parse("2024-05-04 16:50:00"),
          Location = "Conference Room A",
          priority = Priority.High,
          EndDate = DateTime.Parse("2024-05-06"),
          Notes = "No display on the projector"
      },
      new Ticket
      {
          Description = "Database Connection Failure",
          CreatedDate = DateTime.Parse("2024-05-03 08:25:00"),
          Location = "IT Department",
          priority = Priority.High,
          EndDate = DateTime.Parse("2024-05-05"),
          Notes = "Unable to connect to the database server"
      },
      new Ticket
      {
          Description = "Keyboard Malfunction",
          CreatedDate = DateTime.Parse("2024-05-02 12:00:00"),
          Location = "Office 401",
          priority = Priority.Low,
          EndDate = DateTime.Parse("2024-05-04"),
          Notes = "Some keys not working"
      },
      new Ticket
      {
          Description = "Software Crashing",
          CreatedDate = DateTime.Parse("2024-05-01 10:40:00"),
          Location = "Lab 102",
          priority = Priority.Medium,
          EndDate = DateTime.Parse("2024-05-03"),
          Notes = "Software crashes randomly"
      },
      new Ticket
      {
          Description = "Security Access Issue",
          CreatedDate = DateTime.Parse("2024-04-30 15:15:00"),
          Location = "Main Entrance",
          priority = Priority.High,
          EndDate = DateTime.Parse("2024-05-02"),
          Notes = "Access card not working"
      }

  );



        }

    }
}
