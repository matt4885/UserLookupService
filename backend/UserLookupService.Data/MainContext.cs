using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace UserLookupService.Data;

public class MainContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public MainContext(DbContextOptions<MainContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        UserTable(modelBuilder);
    }

    private static void UserTable(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("User");
        modelBuilder.Entity<User>().HasKey(u => u.Id);
        modelBuilder.Entity<User>().Property(u => u.Address)
            .IsRequired()
            .HasMaxLength(95);
        modelBuilder.Entity<User>().Property( u => u.State)
            .IsRequired()
            .HasMaxLength(15);
        modelBuilder.Entity<User>().Property(u => u.ZipCode)
            .IsRequired()
            .HasMaxLength(12);
        modelBuilder.Entity<User>().Property(u => u.GivenName)
            .IsRequired()
            .HasMaxLength(50);
        modelBuilder.Entity<User>().Property(u => u.FamilyName)
            .IsRequired()
            .HasMaxLength(50);
        modelBuilder.Entity<User>().Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(128);
    }
}
