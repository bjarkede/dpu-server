using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dpu_server.Tables;
using Microsoft.EntityFrameworkCore;

namespace dpu_server
{
    public class MyDbContext : DbContext
    {
        //public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=172.25.129.88;Initial Catalog=BookStore;Persist Security Info=True;User ID=sa;Password='F?G2Qt8E.;<4vzuV';");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// Author
            //modelBuilder.Entity<Author>().HasKey(a => new { a.FirstName, a.LastName });

            //// Book
            //modelBuilder.Entity<Book>().HasKey(b => b.Isbn);
            //modelBuilder.Entity<Book>() // One to many
            //    .HasMany<Review>(b => b.Reviews)
            //    .WithOne(r => r.Book)
            //    .HasForeignKey(r => r.BookIsbn);
            //modelBuilder.Entity<Book>()
            //    .HasDiscriminator<string>("type")
            //    .HasValue<Book>("book")
            //    .HasValue<PriceOffer>("PriceOffer");


            //// PriceOffer
            //// Reivew

            //// BookAuthors (many to many)
            //modelBuilder.Entity<BookAuthors>()
            //    .HasOne(ba => ba.Book)
            //    .WithMany(b => b.BookAuthors)
            //    .HasForeignKey(ba => ba.BookIsbn);
            //modelBuilder.Entity<BookAuthors>()
            //    .HasOne(ba => ba.Author)
            //    .WithMany(a => a.BookAuthors)
            //    .HasForeignKey(ba => new { ba.AuthorFirstName, ba.AuthorLastName });

        }

    }
}
