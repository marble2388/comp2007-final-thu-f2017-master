namespace FinalB.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MovieModel : DbContext
    {
        public MovieModel()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Studio> Studios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .Property(e => e.Poster)
                .IsUnicode(false);

            modelBuilder.Entity<Studio>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Studio>()
                .HasMany(e => e.Movies)
                .WithRequired(e => e.Studio)
                .WillCascadeOnDelete(false);
        }
    }
}
