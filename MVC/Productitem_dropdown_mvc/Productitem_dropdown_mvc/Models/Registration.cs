using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Productitem_dropdown_mvc.Models
{
    public class Registration
    {
        [Required(ErrorMessage = "Enter Category")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Enter Products")]
        public string Product { get; set; }
    }
}