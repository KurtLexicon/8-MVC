using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
namespace MVC_8.Models.Home {
    public class CreatePersonViewModel {

        [Display(Name="Name")]
        [Required]
        [RegularExpression(@"^[\w\-\s']{1,40}$")]
        public string Name { get; set; } = "";

        [Display(Name = "City")]
        [RegularExpression(@"^[\w\-\s']{0,40}$")]
        public string City { get; set; } = "";

        [Display(Name = "Phone Number")]
        [RegularExpression(@"^\+?[\d\-\s\(\)]{4,20}$")]
        public string Phone { get; set; } = "";

        public CreatePersonViewModel() {
            Name = "";
            City = "";
            Phone = "";
        }

        public CreatePersonViewModel(string name, string city, string phone) {
            Name = SanitizeNameOrCity(name ?? "");
            City = SanitizeNameOrCity(city ?? "");
            Phone = SanitizePhone(phone ?? "");
        }

        private string SanitizeNameOrCity(string str) {
            // 1. Capitalize
            // 2. Limit length to 30
            return string.Join(" ",
                str.Trim()
                .Split(' ')
                .Select(
                    name =>
                    name[..0].ToUpper() + name[1..30].ToLower()
                 )
            );
        }

        private string SanitizePhone(string str) {
            // 1. Remove letters commonly written in phone numbers, but not actually part of it
            // 2. Check that the reminder consist of an optional "+" followed by 4-15 digits
            str = Regex.Replace(str, @"[\-\s\(\)]+", "");
            Regex rx = new (@"^\+?\d{4,15}$");
            if (!rx.IsMatch(str)) throw new Exception("Invalid phone number");
            return str;
        }
    }
}
