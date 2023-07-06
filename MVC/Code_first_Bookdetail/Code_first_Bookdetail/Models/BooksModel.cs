using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Code_first_Bookdetail.Models
{
    public partial class BooksModel : DbContext
    {
        public BooksModel()
            : base("name=BooksModel")
        {
        }

        public virtual DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(e => e.BookName)
                .IsFixedLength();

            modelBuilder.Entity<Book>()
                .Property(e => e.Price)
                .IsFixedLength();

            modelBuilder.Entity<Book>()
                .Property(e => e.Quantity)
                .IsFixedLength();
        }
    }
}
