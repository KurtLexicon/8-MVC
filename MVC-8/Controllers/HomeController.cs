using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_8.Data;
using MVC_8.Models;
using MVC_8.Models.Home;

namespace MVC_8.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View("ItemPage", new PageViewModel(Person._entitiesName, Person._entityCode, Person._color));
        }

        public IActionResult People() {
            return View("ItemPage", new PageViewModel(Person._entitiesName, Person._entityCode, Person._color));
        }

        public IActionResult Countries() {
            return View("ItemPage", new PageViewModel(Country._entitiesName, Country._entityCode, Country._color));
        }

        public IActionResult Cities() {
            return View("ItemPage", new PageViewModel(City._entitiesName, City._entityCode, City._color));
        }

        public IActionResult About() {
            return View("AboutPage");
        }

        public IActionResult GetCoffee() {
            return StatusCode(418);
        }
    }
}
