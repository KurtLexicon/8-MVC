using Microsoft.AspNetCore.Mvc;
using MVC_8.Data;
using MVC_8.Models.Home;
using MVC_8.Models;
using MVC_8.Models.ViewModels;

namespace MVC_8.Controllers {
    public class CountryController
        : ItemController<
            Country,
            CountryListViewModel,
            CountryViewModel,
            DataStoreCountry> {

        public CountryController(ApplicationDbContext dbContext)
            : base() {
            Ds = new DataStoreCountry(dbContext, dbContext.Countries);
            Entity = Const.Country;

        }

        // === Prepare ViewModel

        override protected CountryViewModel CreateViewModel(Country country) {
            return new CountryViewModel(country);
        }

        override protected void AddViewData(CountryViewModel model) {
            // Nothing to add
        }

        // === Create/Update Item from InputViewModel

        override public void UpdateItemFromInput(CountryViewModel model, Country country) {
            country.Name = model.Name;
        }
    }
}




