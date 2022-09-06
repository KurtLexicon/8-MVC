using Microsoft.AspNetCore.Mvc;
using MVC_8.Data;
using MVC_8.Models.Home;
using MVC_8.Models;
using Microsoft.EntityFrameworkCore;
using MVC_8.Models.ViewModels;

namespace MVC_8.Controllers {
    public class CityController
        : ItemController<
            City,
            CityListViewModel,
            CityViewModel,
            DataStoreCity> {

        public CityController(ApplicationDbContext dbContext)
            : base() {
            Entity = Const.City;
            DbContext = dbContext;
            Ds = new DataStoreCity(dbContext, dbContext.Cities);
        }

        // === Prepare ViewModel

        override protected CityViewModel CreateViewModel(City city) {
            List<Country> countries = Ds.Countries.ToList();
            return new CityViewModel(city, countries);
        }

        override protected void AddViewData(CityViewModel model) {
            List<Country> countries = Ds.Countries.ToList();
            model.AddViewData(countries);
        }

        // === Create/Update Item from InputViewModel

        override public void UpdateItemFromInput(CityViewModel model, City city) {
            city.Name = model.Name;
            city.Country = Ds.GetItemById<Country>(Ds.Countries, model.CountryId);
            city.CountryId = model.CountryId;
        }
    }
}
