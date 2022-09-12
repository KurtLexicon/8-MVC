using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC_8.Data;
using MVC_8.Models;
using MVC_8.Models.Home;
using MVC_8.Models.Shared;
using MVC_8.Models.ViewModels;

namespace MVC_8.Controllers {
    public class PeopleController : Controller {

        private ApplicationDbContext DbContext { get; set; }
        private DataStorePeople Ds { get; set; }
        private EntityConst Entity { get; set; } = Const.Person;

        public PeopleController(ApplicationDbContext dbContext) : base() {
            DbContext = dbContext;
            Ds = new DataStorePeople(dbContext, dbContext.People);
        }

        // ===================================
        // Actions
        // ===================================

        [Authorize(Roles = "Admin,User")]
        public ViewResult Index() {
            return View(new PageViewModel(Entity));
        }

        [Authorize(Roles = "Admin,User")]
        [HttpGet]
        public PartialViewResult GetList(string filterText) {
            int nTotal = Ds.GetNumberOfItems();
            List<EntityItem> items = Ds.GetItemsFiltered(filterText);
            PersonListViewModel model = new();
            model.AddData(items, nTotal, filterText);
            return PartialView(model);
        }

        [Authorize(Roles = "Admin,User")]
        [HttpPost]
        public PartialViewResult GetItem([FromBody] int id) {
            string errorMessage = "";
            Person item;
            try {
                item = id != 0 ? Ds.GetItemById(id) : new();
            }
            catch (DataStore.ItemNotFoundException) {
                item = new();
                errorMessage = $"{Entity.Name} {id} not found";
            }

            PersonViewModel model = new(item, Ds.Cities.ToList(), Ds.Languages.ToList());
            model.AddFail(errorMessage);
            return PartialView(model);
        }

        [Authorize(Roles = "Admin,User")]
        [HttpPost]
        public PartialViewResult AddRandomItem() {
            List<City> cities = Ds.Cities.ToList();
            List<Language> languages = Ds.Languages.ToList();

            Person person = InitData.GetRandomPerson(cities, languages);
            Ds.AddItem(person);

            PersonViewModel model = new(person, cities, languages);
            model.AddSuccess($"{Const.Person.Name} {person.Id} added");

            return PartialView(model);
        }

        [Authorize(Roles = "Admin,User")]
        [HttpPost]
        public PartialViewResult AddItem([FromBody] PersonViewModel input) {
            PersonViewModel model;
            try {
                if (!ModelState.IsValid) throw new InfoException("Please enter valid data");
                if (null == DbContext.Cities.FirstOrDefault(item => item.Id == input.CityId)) {
                    throw new InfoException("The city does not exist");
                }
                List<Language> languages = Ds.GetItemsByIds(Ds.Languages, input.LanguageIds);
                Person person = input.GetItem(languages);
                Person item = Ds.AddItem(person);
                model = new(item, Ds.Cities.ToList(), Ds.Languages.ToList());
                model.AddSuccess($"{Entity.Name} {item.Id} added");
            }

            catch (InfoException ex) {
                model = input;
                model.AddViewData(Ds.Cities, Ds.Languages);
                model.AddFail(ex.Message);
            }

            return PartialView(model);
        }

        [Authorize(Roles = "Admin,User")]
        [HttpPost]
        public PartialViewResult UpdateItem([FromBody] PersonViewModel input) {
            PersonViewModel model;
            try {
                if (!ModelState.IsValid) throw new InfoException("Please enter valid data");
                Person? item = DbContext.People.FirstOrDefault(item => item.Id == input.Id);
                if (item == null) {
                    throw new InfoException($"{Entity.Name} {input.Id} not found");
                }

                item.Name = input.Name;
                item.Phone = input.Phone;
                item.City = Ds.GetItemById(Ds.Cities, input.CityId);
                item.CityId = input.CityId;
                item.Languages = Ds.GetItemsByIds(Ds.Languages, input.LanguageIds);
                Ds.SaveChanges();

                model = new(item, Ds.Cities.ToList(), Ds.Languages.ToList());
                model.AddSuccess($"{Entity.Name} {item.Id} updated");
            }
            catch (InfoException ex) {
                model = input;
                model.AddViewData(Ds.Cities, Ds.Languages);
                model.AddFail(ex.Message);
            }

            return PartialView(model);
        }

        [Authorize(Roles = "Admin,User")]
        [HttpDelete]
        public PartialViewResult DeleteItem(int id) {
            string errorMessage = "";

            try {
                Ds.DeleteItem(id);
            }
            catch (InfoException ex) {
                errorMessage = ex.Message;
            }

            SharedViewModel model = new(errorMessage);
            return PartialView(model);
        }
    }
}
