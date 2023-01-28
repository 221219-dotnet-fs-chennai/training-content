using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Data_EF_DBFirst.Entities;

public partial class RestaurantDbContext : DbContext
{
    string path = File.ReadAllText("../../../../UI-Conxole/connectionString.txt");
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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(path);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Restaurant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RestaurantId");

            entity.Property(e => e.Cuisine).HasDefaultValueSql("('unknown')");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ReviewsId");

            entity.HasOne(d => d.Restaurant).WithMany(p => p.Reviews).HasConstraintName("FK_RestaurantId");

            entity.HasOne(d => d.UsernameNavigation).WithMany(p => p.Reviews).HasConstraintName("FK_Users_Username");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Username).HasName("PK__Users__F3DBC5736AEE8B0C");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
