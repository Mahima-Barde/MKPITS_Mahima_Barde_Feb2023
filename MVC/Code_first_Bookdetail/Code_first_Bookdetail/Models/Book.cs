namespace Code_first_Bookdetail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Book
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string BookName { get; set; }

        [StringLength(10)]
        public string Price { get; set; }

        [StringLength(10)]
        public string Quantity { get; set; }
    }
}
