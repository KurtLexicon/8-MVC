﻿using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_8.Models.Home;
using System.ComponentModel.DataAnnotations;

namespace MVC_8.Models.ViewModels {
    public class CityViewModel : DetailsViewModel {
        private SelectList _countries;

        // Properties

        [Display(Name = "Country")]
        [Required]
        public int CountryId { get; set; } = 0;

        // Constructors

        public CityViewModel() : base(Const.City) {
            _countries = new(Enumerable.Empty<SelectListItem>());
        }

        public CityViewModel(City item, List<Country> countries) : base(Const.City, item) {
            _countries = new(countries, "Id", "Name");
            CountryId = item.Country.Id;
        }

        // Methods

        public void AddViewData(List<Country> countries) {
            _countries = new(countries, "Id", "Name");
        }

        public SelectList SelectCountries() {
            return _countries;
        }

        // Override Methods


        public override City GetItem(DataStore ds, bool getReferencedObjects = true) {
            City city = new() {
                Id = Id,
                Name = Name,
                CountryId = CountryId
            };
            try {
                if (getReferencedObjects)
                    city.Country = ds.GetItemById(ds.Countries, CountryId);
            }
            catch (DataStore.ItemNotFoundException) {
                throw new DataStore.InfoException("Country can not be found");
            }
            return city;

        }

    }
}
