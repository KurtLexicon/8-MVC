using Microsoft.AspNetCore.Mvc;
using MVC_8.Models.Home;
using MVC_8.Models.ViewModels;

namespace MVC_8.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View("ItemPage", new PageViewModel(Const.Person));
        }

        public IActionResult People() {
            return View("ItemPage", new PageViewModel(Const.Person));
        }

        public IActionResult Cities() {
            return View("ItemPage", new PageViewModel(Const.City));
        }

        public IActionResult Countries() {
            return View("ItemPage", new PageViewModel(Const.Country));
        }

        public IActionResult Languages() {
            return View("ItemPage", new PageViewModel(Const.Language));
        }

        public IActionResult About() {
            return View("AboutPage");
        }

        // For test error codes
        public IActionResult GetCoffee() {
            return StatusCode(418);
        }
    }
}
