using Microsoft.EntityFrameworkCore;
namespace Pilot.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Products> Products { get; set; }
    public DbSet<Sales> Sales { get; set; }
    public DbSet<Customers> Customers { get; set; }
    public DbSet<Dealers> Dealers { get; set; }
    public DbSet<Dashboard> Dashboard {  get; set; }
    public DbSet<DashSP> DashSP { get; set; }
}