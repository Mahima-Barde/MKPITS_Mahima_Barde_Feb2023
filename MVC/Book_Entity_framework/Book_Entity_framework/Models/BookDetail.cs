namespace Book_Entity_framework.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookDetail")]
    public partial class BookDetail
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string Bookname { get; set; }

        [StringLength(10)]
        public string Price { get; set; }
    }
}
