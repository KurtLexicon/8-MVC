using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_8.Data;
using MVC_8.Models.Home;
using MVC_8.Models;
using MVC_8.Models.ViewModels;

namespace MVC_8.Controllers {
    public class PersonController
        : ItemController<
            Person,
            PersonListViewModel,
            PersonViewModel,
            DataStorePeople> {

        public PersonController(ApplicationDbContext dbContext)
            : base() {
            Ds = new DataStorePeople(dbContext, dbContext.People);
            Entity = Const.Person;
        }

        // === Prepare ViewModel

        override protected PersonViewModel CreateViewModel(Person person) {
            List<City> cities = Ds.Cities.ToList();
            List<Language> language = Ds.Languages.ToList();
            return new PersonViewModel(person, cities, language);
        }

        override protected void AddViewData(PersonViewModel model) {
            List<City> cities = Ds.Cities.ToList();
            List<Language> language = Ds.Languages.ToList();
            model.AddViewData(cities, language);
        }

        // === Create/Update Item from InputViewModel

        override public void UpdateItemFromInput(PersonViewModel model, Person person) {
            person.Name = model.Name;
            person.Phone = model.Phone;
            person.City = Ds.GetItemById(Ds.Cities, model.CityId);
            person.CityId = model.CityId;
            person.Languages = Ds.GetItemsByIds<Language>(Ds.Languages, model.LanguageIds);
        }

        // === Add random person

        [HttpPost]
        public IActionResult AddRandomItem() {
            List<City> cities = Ds.Cities.ToList();
            List<Language> languages = Ds.Languages.ToList();

            Person person = InitData.GetRandomPerson(cities,languages);
            Ds.AddItem(person);

            PersonViewModel model =  new (person, cities, languages);
            model.AddSuccess($"{Const.Person.Name} {person.Id} added");

            return View("PvDetail", model);
        }
    }
}
