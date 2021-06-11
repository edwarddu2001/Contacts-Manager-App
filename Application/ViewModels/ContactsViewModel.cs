using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels
{
    public class ContactsViewModel
    {
        [Required(ErrorMessage = "Name is Required")]
        [StringLength(15, ErrorMessage = "Name is Too Long")]
        [RegularExpression("[A-Za-z ]+", ErrorMessage = "Name can Only Contain Letters or Spaces")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone Number is Required")]
        [RegularExpression("^[0-9]{3}-[0-9]{3}-[0-9]{4}$", ErrorMessage = "Incorrect Format for Phone Number (ex. ###-###-####)")]
        public string PhoneNum { get; set; }
    }
}