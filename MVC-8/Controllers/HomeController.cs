using Microsoft.AspNetCore.Mvc;
using MVC_8.Models;
using MVC_8.Models.Home;

namespace MVC_8.Controllers {
    public class HomeController : Controller {
        ControllerUtils Utils { get { return new(HttpContext); } }
        const string SessionDataKey = "PeopleData";

        public IActionResult Index() {
            return View(GetSessionData());
        }

        public IActionResult AddPerson(CreatePersonViewModel input) {
            PeopleViewModel model = GetSessionData();
            if (ModelState.IsValid) {
                model.People.Add(new Person(input));
                // If there's no error then clear input boxes
                model.Name = "";
                model.City = "";
                model.Phone = "";
            } else {
                // If there's an error then set input boxes
                model.Name = input.Name;
                model.City = input.City;
                model.Phone = input.Phone;
                // Just for debugging
                var errors = ModelState.Values.SelectMany(v => v.Errors).ToList();
                string err = string.Join("<br>", errors.Select(error => error.ErrorMessage));
            }
            model.ShowAddPerson = true;
            model.ShowFilter = false;
            SetSessionData(model);
            return View("Index", model);
        }

        public IActionResult SetFilter(string filter) {
            PeopleViewModel model = GetSessionData();
            model.Filter = filter;
            model.ShowAddPerson = false;
            model.ShowFilter = true;
            SetSessionData(model);
            return View("Index", model);
        }

        // Helpers

        private PeopleViewModel GetSessionData() {
            return Utils.GetSessionData<PeopleViewModel>(SessionDataKey) ?? new PeopleViewModel(5);
        }

        private void SetSessionData(PeopleViewModel data) {
            Utils.SetSessionData(SessionDataKey, data);
        }
    }
}
