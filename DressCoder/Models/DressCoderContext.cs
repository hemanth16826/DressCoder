using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DressCoder.Models;

public partial class DressCoderContext : DbContext
{
    public DressCoderContext()
    {
    }

    public DressCoderContext(DbContextOptions<DressCoderContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<UserLogin> UserLogins { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ProductName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProductSize)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserLogin>(entity =>
        {
            entity.HasKey(e => e.LoginId);

            entity.Property(e => e.LoginPassword).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
