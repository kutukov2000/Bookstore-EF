using exam_entity.Entities;
using exam_entity.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_entity
{
    public class BookShopDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<BookInStore> BooksInStore { get; set; }

        public BookShopDbContext() {  }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-51KUJIC\SQLEXPRESS;
                                            Initial Catalog = BookShop;
                                            Integrated Security=True;
                                            Connect Timeout=2;Encrypt=False;
                                            TrustServerCertificate=False;
                                            ApplicationIntent=ReadWrite;
                                            MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().Property(b => b.Title).HasMaxLength(255).IsRequired();
            modelBuilder.Entity<Book>().Property(b => b.Comment).HasMaxLength(255);
            modelBuilder.Entity<Book>().HasOne(b => b.Author).WithMany(a => a.Books).HasForeignKey(b => b.AuthorId);
            modelBuilder.Entity<Book>().HasOne(b => b.Genre).WithMany(g => g.Books).HasForeignKey(b => b.GenreId);
            modelBuilder.Entity<Book>().HasOne(b => b.BookInStore).WithOne(b => b.Book).HasForeignKey<BookInStore>(b => b.BookId);


            modelBuilder.Entity<Author>().Property(a => a.Name).HasMaxLength(255).IsRequired();
            modelBuilder.Entity<Author>().HasOne(a => a.Country).WithMany(c => c.Authors).HasForeignKey(a => a.CountryId);

            modelBuilder.Entity<Genre>().Property(g => g.Name).HasMaxLength(255).IsRequired();


            modelBuilder.Entity<Country>().Property(c => c.Name).HasMaxLength(255).IsRequired();

            modelBuilder.Entity<BookInStore>().Property(b=>b.Discount).HasDefaultValue(0);

            modelBuilder.SeedCountries();
            modelBuilder.SeedGenres();
            modelBuilder.SeedAuthors();
            modelBuilder.SeedBooks();
            modelBuilder.SeedBookInStore();
        }
    }
}
