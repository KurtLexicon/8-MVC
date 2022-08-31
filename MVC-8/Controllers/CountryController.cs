using Microsoft.AspNetCore.Mvc;
using MVC_8.Data;
using MVC_8.Models.Home;

namespace MVC_8.Controllers {
    public class CountryController
        : ItemController<
            Country, 
            Country.ListViewModel, 
            Country.InputViewModel> {

        public CountryController(ApplicationDbContext dbContext)
            : base(dbContext, dbContext.Countries) {
        }
    }
}