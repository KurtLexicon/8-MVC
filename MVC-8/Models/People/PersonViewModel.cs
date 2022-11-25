using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MVC_8.Models {
    public class PersonViewModel : DetailsViewModel {
        SelectList _cities = new(Enumerable.Empty<SelectListItem>());
        SelectList _languages = new(Enumerable.Empty<SelectListItem>());

        public List<SelectListItem> SelectListCities { get; set; } = new();
        public List<SelectListItem> SelectListLanguages { get; set; } = new();

        // Properties(other than Id & Name)

        [Display(Name = "City")]
        [Required]
        public int CityId { get; set; } = 0;
        public string CityName { get; set; } = "";
        public string CountryName { get; set; } = "";


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
            CityName = item.City != null ? item.City.Name : "";
            CountryName = item.City != null && item.City.Country != null ? item.City.Country.Name : "";
            LanguageIds = item.Languages.Select(l => l.Id).ToList();
            AddViewData(cities, languages);
        }

        // Methods

        public void AddViewData(IEnumerable<City> cities, IEnumerable<Language> languages) {
            _cities = new(cities, "Id", "Name");
            _languages = new(languages, "Id", "Name");

            cities.ToList().ForEach(x => { x.Country.Cities = new(); });
            languages.ToList().ForEach(x => { x.People = new(); });

            SelectListCities.Clear();
            foreach (City city in cities)
            {
                SelectListCities.Add(new(city.Id.ToString(), city.Name));
            }

            SelectListLanguages.Clear();
            foreach (Language language in languages)
            {
                SelectListLanguages.Add(new(language.Id.ToString(), language.Name));
            }
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
