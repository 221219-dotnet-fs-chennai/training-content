using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataFluentApi.Entities;

public partial class RestaurantDbContext : DbContext
{
    //string path = File.ReadAllText("../../../../UI-Conxole/connectionString.txt");
    public RestaurantDbContext()
    {
    }

    public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Restaurant> Restaurants { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<User> Users { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

    //    => optionsBuilder.UseSqlServer(path);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Restaurant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RestaurantId");

            entity.Property(e => e.Cuisine)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('unknown')");
            entity.Property(e => e.Email)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Website)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Zipcode)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ReviewsId");

            entity.Property(e => e.Comment).IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");

            entity.HasOne(d => d.Restaurant).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.RestaurantId)
                .HasConstraintName("FK_RestaurantId");

            entity.HasOne(d => d.UsernameNavigation).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.Username)
                .HasConstraintName("FK_Users_Username");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Username).HasName("PK__Users__F3DBC5736AEE8B0C");

            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
            entity.Property(e => e.Password)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
