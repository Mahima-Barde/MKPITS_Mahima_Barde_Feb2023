using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Book_Entity_framework.Models
{
    public partial class databookmodel : DbContext
    {
        public databookmodel()
            : base("name=databookmodel")
        {
        }

        public virtual DbSet<BookDetail> BookDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookDetail>()
                .Property(e => e.Bookname)
                .IsFixedLength();

            modelBuilder.Entity<BookDetail>()
                .Property(e => e.Price)
                .IsFixedLength();
        }
    }
}
