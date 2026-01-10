using ticket.Models;
namespace ticket.Data;
using Microsoft.EntityFrameworkCore;

public class AppDbContext: DbContext
{
    public DbSet<Event> Events { get; set; }
    public DbSet<Ticket> Tickets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost,1433;Database=ConsoleAppDb;User Id=sa;Password=CodeWithArjun123;TrustServerCertificate=True;"
        );
    }
}