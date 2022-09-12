using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_8.Models.Home;
using System.ComponentModel.DataAnnotations;
using MVC_8.Models.Shared;

namespace MVC_8.Models.ViewModels {
    public class PersonViewModel : DetailsViewModel {
        SelectList _cities = new(Enumerable.Empty<SelectListItem>());
        SelectList _languages = new(Enumerable.Empty<SelectListItem>());

        // Properties(other than Id & Name)

        [Display(Name = "City")]
        [Required]
        public int CityId { get; set; } = 0;

        [Display(Name = "Phone Number")]
        // Format "+DD-DD DD DD", with "+" and "-" and blanks optional, minimum 3 digits after dash
        [RegularExpression(@"^[\+]?(\d+\s*\-)?(?:\d[\s]*){3,}$", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; } = "";

        [Display(Name = "Languages")]
        [BindProperty]
        public List<int> LanguageIds { get; set; } = new();

        // Constructors

        public PersonViewModel() : base(Const.Person) { }

        public PersonViewModel(Person item, IEnumerable<City> cities, IEnumerable<Language> languages) : base(Const.Person, item) {
            Phone = item.Phone;
            CityId = item.City != null ? item.City.Id : 0;
            LanguageIds = item.Languages.Select(l => l.Id).ToList();
            AddViewData(cities, languages);
        }

        // Methods

        public void AddViewData(IEnumerable<City> cities, IEnumerable<Language> languages) {
            _cities = new(cities, "Id", "Name");
            _languages = new(languages, "Id", "Name");
        }

        public SelectList SelectCities() {
            return _cities;
        }

        public SelectList SelectLanguages() {
            return _languages;
        }

        // Override Methods

        public Person GetItem(List<Language> languages) {
            Person person = new() {
                Id = Id,
                Name = Name,
                Phone = Phone,
                CityId = CityId,
                Languages = languages
            };
            return person;
        }
    }
}
