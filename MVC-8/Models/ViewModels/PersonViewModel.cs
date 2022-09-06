using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_8.Models.Home;
using System.ComponentModel.DataAnnotations;

namespace MVC_8.Models.ViewModels {
    public class PersonViewModel : DetailsViewModel {
        SelectList _cities;
        SelectList _languages;

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

        public PersonViewModel() : base(Const.Person) {
            _cities = new(Enumerable.Empty<SelectListItem>());
            _languages = new(Enumerable.Empty<SelectListItem>());
        }

        public PersonViewModel(Person item, List<City> cities, List<Language> languages) : base(Const.Person, item) {
            _cities = new(cities, "Id", "Name"); ;
            _languages = new(languages, "Id", "Name"); ;
            Phone = item.Phone;
            CityId = item.City.Id;
            LanguageIds = item.Languages.Select(l => l.Id).ToList();
        }

        // Methods

        public void AddViewData(List<City> cities, List<Language> languages) {
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

        public override Person GetItem(DataStore ds, bool getReferencedObjects = true) {
            Person person = new() {
                Id = Id,
                Name = Name,
                Phone = Phone,
                CityId = CityId,
            };
            if (getReferencedObjects) {
                person.Languages = ds.GetItemsByIds(ds.Languages, LanguageIds);
                try {
                    person.City = ds.GetItemById(ds.Cities, CityId);
                }
                catch (DataStore.ItemNotFoundException) {
                    throw new DataStore.InfoException("City can not be found");
                }
            }
            return person;
        }
    }
}
