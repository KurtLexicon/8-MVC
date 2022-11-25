using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MVC_8.Models {
    public class CityViewModel : DetailsViewModel {
        private SelectList _countries;

        public List<SelectListItem> SelectListCountries { get; set; } = new();

        // Properties

        [Display(Name = "Country")]
        [Required]
        public int CountryId { get; set; } = 0;
        public string CountryName { get; set; } = "";

        // Constructors

        public CityViewModel() : base(Const.City) {
            _countries = new(Enumerable.Empty<SelectListItem>());
        }

        public CityViewModel(City item, List<Country> countries) : base(Const.City, item) {
            _countries = new(countries, "Id", "Name");
            CountryId = item.CountryId;
            CountryName = item.Country?.Name ?? "";
            AddViewData(countries);
        }

        // Methods

        public void AddViewData(List<Country> countries) {
            _countries = new(countries, "Id", "Name");
            countries.ToList().ForEach(x => { x.Cities = new(); });
            SelectListCountries.Clear();
            foreach (Country country in countries)
            {
                SelectListCountries.Add(new(country.Id.ToString(), country.Name));
            }
        }

        public SelectList SelectCountries() {
            return _countries;
        }

        // Override Methods

        public City GetItem() {
            City city = new() {
                Id = Id,
                Name = Name,
                CountryId = CountryId
            };
            return city;
        }
    }
}
