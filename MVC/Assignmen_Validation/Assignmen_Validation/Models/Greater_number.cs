using System.ComponentModel.DataAnnotations;
namespace Assignmen_Validation.Models
{
    public class Greater_number
    {
        //public string result { get; set; }
        [Required(ErrorMessage ="Number1 is required")]
        public int number1 { get; set; }

        [Required(ErrorMessage = "Number2 is required")]
        public int number2 { get; set; }

    }
}
