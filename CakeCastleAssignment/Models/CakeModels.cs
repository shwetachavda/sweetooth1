namespace CakeCastleAssignment.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CakeModels : DbContext
    {
        public CakeModels()
            : base("name=CakeConnection")
        {
        }

        public virtual DbSet<Cake> Cakes { get; set; }
        public virtual DbSet<ChocolateCake> ChocolateCakes { get; set; }
        public virtual DbSet<CoffeeCake> CoffeeCakes { get; set; }
        public virtual DbSet<FruitCake> FruitCakes { get; set; }
        public virtual DbSet<SpongeCake> SpongeCakes { get; set; }
        public virtual DbSet<ThemeCake> ThemeCakes { get; set; }
        public virtual DbSet<WeddingCake> WeddingCakes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cake>()
                .Property(e => e.CakeName)
                .IsUnicode(false);

            modelBuilder.Entity<ChocolateCake>()
                .Property(e => e.CakeName)
                .IsUnicode(false);

            modelBuilder.Entity<ChocolateCake>()
                .Property(e => e.CakesDesc)
                .IsUnicode(false);

            modelBuilder.Entity<ChocolateCake>()
                .Property(e => e.Rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<CoffeeCake>()
                .Property(e => e.CakeName)
                .IsUnicode(false);

            modelBuilder.Entity<CoffeeCake>()
                .Property(e => e.CakesDesc)
                .IsUnicode(false);

            modelBuilder.Entity<CoffeeCake>()
                .Property(e => e.Rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<FruitCake>()
                .Property(e => e.CakeName)
                .IsUnicode(false);

            modelBuilder.Entity<FruitCake>()
                .Property(e => e.CakesDesc)
                .IsUnicode(false);

            modelBuilder.Entity<FruitCake>()
                .Property(e => e.Rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<SpongeCake>()
                .Property(e => e.CakeName)
                .IsUnicode(false);

            modelBuilder.Entity<SpongeCake>()
                .Property(e => e.CakesDesc)
                .IsUnicode(false);

            modelBuilder.Entity<SpongeCake>()
                .Property(e => e.Rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ThemeCake>()
                .Property(e => e.CakeName)
                .IsUnicode(false);

            modelBuilder.Entity<ThemeCake>()
                .Property(e => e.CakesDesc)
                .IsUnicode(false);

            modelBuilder.Entity<ThemeCake>()
                .Property(e => e.Rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<WeddingCake>()
                .Property(e => e.CakeName)
                .IsUnicode(false);

            modelBuilder.Entity<WeddingCake>()
                .Property(e => e.CakesDesc)
                .IsUnicode(false);

            modelBuilder.Entity<WeddingCake>()
                .Property(e => e.Rate)
                .HasPrecision(5, 2);
        }
    }
}
