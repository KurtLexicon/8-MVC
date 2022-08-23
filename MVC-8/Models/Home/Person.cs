using System.ComponentModel.DataAnnotations;


namespace MVC_8.Models.Home {
    public class Person {
        [Display(Name = "Name")]
        [Required]
        [RegularExpression(@"^[\w\-\s']{1,40}$")]
        public string Name { get; set; } = "";

        [Display(Name = "City")]
        [RegularExpression(@"^[\w\-\s']{0,40}$")]
        public string City { get; set; } = "";

        [Display(Name = "Phone Number")]
        [RegularExpression(@"^\++[\d\-\s\(\)]{4,20}$")]
        public string Phone { get; set; } = "";

        public Person() {
            Name = "";
            City = "";
            Phone = "";
        }

        public Person(CreatePersonViewModel input) {
            if(input != null) {
                Name = input.Name;
                City = input.City;
                Phone = input.Phone;
            } else {
                Name = "";
                City = "";
                Phone = "";
            }
        }
    }
}
