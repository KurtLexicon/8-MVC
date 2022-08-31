using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_8.Data;
using MVC_8.Models.Home;
namespace MVC_8.Controllers {
    public class PersonController
        : ItemController<
            Person,
            Person.ListViewModel,
            Person.InputViewModel> {

        public PersonController(ApplicationDbContext dbContext)
            : base(dbContext, dbContext.People) {
        }

        // === Add random person

        [HttpPost]
        public IActionResult AddRandomItem() {
            List<City> cities = Ds.Cities.ToList();
            Person item = InitData.GetRandomPerson(cities);

            Ds.AddItem(item);
            ItemInputViewModel model = item.GetItemInputViewModel(Ds);
            model.AddSuccess($"{item.GetEntityCode()} {item.Id} added");
            return View("PvDetail", model);
        }
    }
}
