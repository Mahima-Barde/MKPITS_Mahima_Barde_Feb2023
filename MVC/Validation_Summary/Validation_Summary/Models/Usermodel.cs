using System.ComponentModel.DataAnnotations;

namespace Validation_Summary.Models;
     public class Usermodel
    {
        [Required(ErrorMessage ="Required Username")]
        public string Username { get; set; }
         [Required(ErrorMessage ="Required Mobile number")]
         public string mobileno { get; set; }
    }

 
  
