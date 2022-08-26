using Microsoft.AspNetCore.Mvc;
using MVC_8.Models;
using MVC_8.Models.Home;

namespace MVC_8.Controllers {
    public class HomeController : Controller {

        // =======================================
        // Main Pages
        // =======================================

        public IActionResult Index() {
            return View("PeoplePage");
        }

        public IActionResult About() {
            return View("AboutPage");
        }

        public IActionResult TestErrorCode() {
            return StatusCode(418);
        }


        // =======================================
        // Manage filter and people list
        // =======================================
        public class FilterParams {
            public FilterParams() {
                Filter = "";
            }
            public string Filter { get; set; }
        }

        [HttpPost]
        public ActionResult SetFilterGetPeopleList([FromBody] FilterParams p) {
            PeopleData people = DataStore.PeopleData;

            PeopleListViewModel model = new(people, p.Filter);
            return View("PartialViewPeopleList", model);
        }

        // =======================================
        // Manage persons
        // =======================================

        // === Get Person

        public class ShowPersonParams {
            public ShowPersonParams() {
                Id = 0;
            }
            public int Id { get; set; }
        }

        [HttpPost]
        public IActionResult ShowPerson([FromBody] ShowPersonParams p) {
            int id = p.Id;
            PeopleData people = DataStore.PeopleData;
            ResponseData responseData = new();

            Person person;
            if (id == 0) {
                person = new();
            } else {
                try {
                    person = people.GetPersonById(id);
                }
                catch (PeopleData.PersonIdNotFoundException) {
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
            PeopleData people = DataStore.PeopleData;
            Person person = RandomData.GetRandomPerson();
            people.AddPerson(person);
            CreatePersonViewModel model = new(person);
            model.AddSuccess($"Random person {person.Id} Added");
            return View("PartialViewPerson", model);
        }

        // === Add or Update Person

        [HttpPost]
        public IActionResult AddOrUpdatePerson([FromBody] CreatePersonViewModel input) {
            PeopleData people = DataStore.PeopleData;

            Person person;
            CreatePersonViewModel model;

            if (ModelState.IsValid && input.Id == 0) { 
                person = people.AddPerson(new Person(input));
                model = new(person);
                model.AddSuccess($"Person {person.Id} added");

            } else if (ModelState.IsValid && input.Id != 0) {
                try {
                    person = people.UpdatePerson(input);
                    model = new(person);
                    model.AddSuccess($"Person {person.Id} updated");
                }
                catch (PeopleData.PersonIdNotFoundException) {
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
            PeopleData people = DataStore.PeopleData;

            try {
                people.DeletePerson(id);
            }
            catch (PeopleData.PersonIdNotFoundException){
                // Person to delete not found, maybe deleted already, just let it pass
            }

            PeopleListViewModel model = new(people, filter);
            return View("PartialViewPeopleList", model);
        }
    }
}
