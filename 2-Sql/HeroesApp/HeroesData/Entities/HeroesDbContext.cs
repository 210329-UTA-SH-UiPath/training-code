using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HeroesData.Entities
{
    public partial class HeroesDbContext : DbContext// make session with the database which is used to perform CRUD operation in DB
    {
        public HeroesDbContext()
        {
        }

        public HeroesDbContext(DbContextOptions<HeroesDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SuperHero> SuperHeroes { get; set; }
        public virtual DbSet<SuperPower> SuperPowers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<SuperHero>(entity =>
            {
                entity.ToTable("SuperHero");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HideOut)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RealName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SuperPower>(entity =>
            {
                entity.ToTable("SuperPower");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.SuperHeroId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("superHeroId");

                entity.HasOne(d => d.SuperHero)
                    .WithMany(p => p.SuperPowers)
                    .HasForeignKey(d => d.SuperHeroId)
                    .HasConstraintName("FK_SuperPower_SuperHero");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
