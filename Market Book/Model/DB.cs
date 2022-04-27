using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Market_Book.Model
{
    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
        }

        public virtual DbSet<AuthorBook> AuthorBook { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Market> Market { get; set; }
        public virtual DbSet<MarketBook> MarketBook { get; set; }
        public virtual DbSet<Receipt> Receipt { get; set; }
        public virtual DbSet<ReceiptBook> ReceiptBook { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorBook>()
                .HasMany(e => e.Book)
                .WithRequired(e => e.AuthorBook)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.MarketBook)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Market>()
                .HasMany(e => e.MarketBook)
                .WithRequired(e => e.Market)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MarketBook>()
                .HasMany(e => e.ReceiptBook)
                .WithRequired(e => e.MarketBook)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Receipt>()
                .HasMany(e => e.ReceiptBook)
                .WithRequired(e => e.Receipt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Login)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .HasMany(e => e.Receipt)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
