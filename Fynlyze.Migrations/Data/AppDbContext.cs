using Microsoft.EntityFrameworkCore;

namespace Finlyze.Migrations.Data.Context;

public class AppDbContext : DbContext
{
    // public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=FinlyzeDb;User Id=sa;Password=Lucas1971!;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

}