using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
namespace MVC_8.Models.Home {
    public class CreatePersonViewModel {
        [Required]
        public int Id { get; set; } = 0;

        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; } = "";

        [Display(Name = "City")]
        [Required]
        public string City { get; set; } = "";



        [Display(Name = "Phone Number")]
        // Format "+DD-DD DD DD", with "+" and "-" and blanks optional, minimum 3 digits aftr dash
        [RegularExpression(@"^[\+]?(\d+\s*\-)?(?:\d[\s]*){3,}$", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; } = "";


        public string Message { get; set; } = "";
        public bool IsSuccess { get; set; } = true;


        public CreatePersonViewModel() {
            Id = 0;
            Name = "";
            City = "";
            Phone = "";
        }

        public CreatePersonViewModel(Person person) {
            Id = person.Id;
            Name = person.Name;
            City = person.City;
            Phone = person.Phone;
        }

        public CreatePersonViewModel(Person person, ResponseData responseData) {
            Id = person.Id;
            Name = person.Name;
            City = person.City;
            Phone = person.Phone;
            IsSuccess = responseData.IsSuccess;
            Message = responseData.Message;
        }

        public void AddFail(string str) {
            IsSuccess = false;
            Message = str;
        }

        public void AddSuccess(string str) {
            IsSuccess = true;
            Message = str;
        }
    }
}
