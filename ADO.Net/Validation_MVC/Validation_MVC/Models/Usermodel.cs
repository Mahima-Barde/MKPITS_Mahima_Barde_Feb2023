using System.ComponentModel.DataAnnotations;

namespace Validation_MVC.Models
{
    public class Usermodel
    {

        //Required: Specifies that Input field cannot be empty.
        //[required(ErrorMesaage="Name is required")]


        [Required(ErrorMessage = "Name is required.It canonot be empty")]
        public string username { get; set; }
    }
}
