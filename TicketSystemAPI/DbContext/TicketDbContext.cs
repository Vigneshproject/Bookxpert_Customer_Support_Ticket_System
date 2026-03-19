namespace TicketSystemAPI.DbContext
{
    using Microsoft.EntityFrameworkCore;
    using TicketSystemAPI.Models;

    public class TicketDbContext : DbContext
    {
        public TicketDbContext(DbContextOptions<TicketDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<TicketComment> TicketComments { get; set; }

        public DbSet<TicketStatusHistory> TicketStatusHistory { get; set; }
    }
}
