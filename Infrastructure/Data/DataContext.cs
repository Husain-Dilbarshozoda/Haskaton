using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class DataContext(DbContextOptions options):DbContext(options)
{
    public DbSet<Hackathons> Hackathons { get; set; }
    public DbSet<Teams> Teams { get; set; }
    public DbSet<Participants> Participants { get; set; }
    
}