using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EXAM_MusicCollection_EDM
{
    public partial class MusicCollectionModel : DbContext
    {
        public MusicCollectionModel()
            : base("name=MusicCollectionModelEDM")
        {
        }

        public virtual DbSet<Artists> Artists { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }
        public virtual DbSet<Records> Records { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Years> Years { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artists>()
                .HasMany(e => e.Records)
                .WithRequired(e => e.Artists)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Genres>()
                .HasMany(e => e.Records)
                .WithRequired(e => e.Genres)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Records>()
                .Property(e => e.Cost)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Records>()
                .Property(e => e.SalePrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Years>()
                .HasMany(e => e.Records)
                .WithRequired(e => e.Years)
                .WillCascadeOnDelete(false);
        }
    }
}
