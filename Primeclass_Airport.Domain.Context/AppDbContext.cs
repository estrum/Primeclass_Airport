using Microsoft.EntityFrameworkCore;
using Primeclass_Airport.Domain.Entities;

namespace Primeclass_Airport.Domain.Context;

public class AppDbContext : DbContext
{
    protected AppDbContext(DbContextOptions options) : base(options) { }

    // Tablas de la base de datos
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<UserRole> UserRoles { get; set; } = null!;
    public DbSet<Lounge> Lounges { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
    public DbSet<Log> Logs { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuración de claves compuestas
        modelBuilder.Entity<OrderDetail>()
            .HasKey(od => new { od.OrderId, od.ProductId });

        modelBuilder.Entity<Order>()
            .Property(o => o.Status)
            .HasConversion<int>();

        modelBuilder.Entity<Order>()
            .HasMany(o => o.Details)
            .WithOne(od => od.Order)
            .HasForeignKey(od => od.OrderId);
    }
}
