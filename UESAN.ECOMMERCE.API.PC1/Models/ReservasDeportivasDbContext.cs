using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace UESAN.ECOMMERCE.API.PC1.Models;

public partial class ReservasDeportivasDbContext : DbContext
{
    public ReservasDeportivasDbContext()
    {
    }

    public ReservasDeportivasDbContext(DbContextOptions<ReservasDeportivasDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cancha> Canchas { get; set; }

    public virtual DbSet<Reserva> Reservas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cancha>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Canchas__3214EC0781002EB7");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Reserva>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reservas__3214EC07A942EEA3");

            entity.Property(e => e.ClienteNombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Canch).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.CanchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reservas__CanchI__267ABA7A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
