using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Project07_EfCore_DbFirst_Portfolio.Data.Entities;

namespace Project07_EfCore_DbFirst_Portfolio.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<About> Abouts { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<HomeBanner> HomeBanners { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<ServiceInfo> ServiceInfos { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    public virtual DbSet<SocialMediaAccount> SocialMediaAccounts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-488APMT\\SQLSERVER;Database=PortfolioDb;User=sa;Password=1234;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<About>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("trg_UpdateAt_Abouts"));

            entity.Property(e => e.Id).HasDefaultValue(1);
            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.UpdatedAt).HasPrecision(3);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC0737975745");

            entity.ToTable(tb => tb.HasTrigger("trg_UpdateAt_Categories"));

            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Description).HasDefaultValue("Kategori açıklaması");
            entity.Property(e => e.UpdatedAt).HasPrecision(3);
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable(tb => tb.HasTrigger("trg_UpdateAt_Contacts"));

            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).HasDefaultValue(1);
            entity.Property(e => e.UpdatedAt).HasPrecision(3);
        });

        modelBuilder.Entity<HomeBanner>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable(tb => tb.HasTrigger("trg_UpdateAt_HomeBanners"));

            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).HasDefaultValue(1);
            entity.Property(e => e.UpdatedAt).HasPrecision(3);
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Messages__3214EC0776990470");

            entity.Property(e => e.ReadingDate).HasPrecision(3);
            entity.Property(e => e.SendingDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Projects__3214EC07DF41977E");

            entity.ToTable(tb => tb.HasTrigger("trg_UpdateAt_Projects"));

            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Description).HasDefaultValue("Proje açıklaması");
            entity.Property(e => e.UpdatedAt).HasPrecision(3);

            entity.HasOne(d => d.Category).WithMany(p => p.Projects)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Projects__Catego__5070F446");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Services__3214EC07CEC44375");

            entity.ToTable(tb => tb.HasTrigger("trg_UpdateAt_Services"));

            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Icon).HasDefaultValue("~/ui/img/services/s1.png");
            entity.Property(e => e.UpdatedAt).HasPrecision(3);
        });

        modelBuilder.Entity<ServiceInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable(tb => tb.HasTrigger("trg_UpdateAt_ServiceInfos"));

            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).HasDefaultValue(1);
            entity.Property(e => e.UpdatedAt).HasPrecision(3);
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable(tb => tb.HasTrigger("trg_UpdateAt_Settings"));

            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).HasDefaultValue(1);
            entity.Property(e => e.UpdatedAt).HasPrecision(3);
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Skills__3214EC0763576CAD");

            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.UpdatedAt).HasPrecision(3);
        });

        modelBuilder.Entity<SocialMediaAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SocialMe__3214EC07AC9DD5EB");

            entity.ToTable(tb => tb.HasTrigger("trg_UpdateAt_SocialMediaAccounts"));

            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.UpdatedAt).HasPrecision(3);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
