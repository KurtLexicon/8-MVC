using Microsoft.AspNetCore.Mvc;
using MVC_8.Data;
using MVC_8.Models.Home;

namespace MVC_8.Controllers {
    public class CityController
        : ItemController<
            City,
            City.ListViewModel,
            City.InputViewModel> {

        public CityController(ApplicationDbContext dbContext)
            : base(dbContext, dbContext.Cities) {
        }

    }
}
