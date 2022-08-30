using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_8.Data;
using MVC_8.Models;
using MVC_8.Models.Home;

namespace MVC_8.Controllers {
    public class HomeController : Controller {
        private DataStore DataStore { get; set; }

        public HomeController(ApplicationDbContext dbContext) : base() {
            DataStore = new(dbContext);
        }

        // =======================================
        // Main Pages
        // =======================================


        public IActionResult Index() {
            return View("PeoplePage");
        }

        public IActionResult About() {
            return View("AboutPage");
        }

        public IActionResult GetCoffee() {
            return StatusCode(418);
        }

        // =======================================
        // Get People
        // =======================================

        [HttpPost]
        public ActionResult GetPeople([FromBody] string filter) {
            int nPeople = DataStore.GetNumberOfPeople();
            List<Person> people = DataStore.GetPeopleFiltered(filter);
            PeopleListViewModel model = new(people, nPeople, filter);
            return View("PartialViewPeopleList", model);
        }

        // =======================================
        // Manage persons
        // =======================================

        // === Get Person

        [HttpPost]
        public IActionResult GetPerson([FromBody] int id) {
            ResponseData responseData = new();

            Person person;
            if (id == 0) {
                person = new();
            } else {
                try {
                    person = DataStore.GetPersonById(id);
                }
                catch (DataStore.PersonNotFoundException) {
                    person = new();
                    responseData.SetFail($"Person {id} not found");
                }
            }

            CreatePersonViewModel model = new(person, responseData);
            return View("PartialViewPerson", model);
        }

        // === Add random person

        [HttpPost]
        public IActionResult AddRandomPerson() {
            Person person = DataStore.AddPerson(RandomData.GetRandomPerson());
            CreatePersonViewModel model = new(person);
            model.AddSuccess($"Random person {person.Id} Added");
            return View("PartialViewPerson", model);
        }

        // === Add or Update Person

        [HttpPost]
        public IActionResult AddOrUpdatePerson([FromBody] CreatePersonViewModel input) {
            CreatePersonViewModel model;

            if (ModelState.IsValid && input.Id == 0) {
                Person person = DataStore.AddPerson(new Person(input));
                model = new(person);
                model.AddSuccess($"Person {person.Id} added");

            } else if (ModelState.IsValid && input.Id != 0) {
                try {
                    Person person = DataStore.UpdatePerson(input);
                    model = new(person);
                    model.AddSuccess($"Person {person.Id} updated");
                }
                catch (DataStore.PersonNotFoundException) {
                    model = input;
                    model.AddFail($"Person {input.Id} not found");
                }

            } else {
                model = input;
                model.AddFail("Please enter valid data");
            }

            return View("PartialViewPerson", model);
        }

        // === Delete Person 

        public class ReqBodyDelete {
            public ReqBodyDelete() {
                Id = 0;
                Filter = string.Empty;
            }
            public int Id { get; set; }
            public string Filter { get; set; }
        }

        [HttpPost]
        public IActionResult DeletePersonGetPeopleList([FromBody] ReqBodyDelete req) {
            int id = req.Id;
            string filter = req.Filter;

            try {
                DataStore.DeletePerson(id);
            }
            catch (DataStore.PersonNotFoundException) {
                // Person to delete not found, maybe deleted already, just let it pass
            }

            int nPeople = DataStore.GetNumberOfPeople();
            List<Person> people = DataStore.GetPeopleFiltered(filter);
            PeopleListViewModel model = new(people, nPeople, filter);
            return View("PartialViewPeopleList", model);
        }
    }
}
