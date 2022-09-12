using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC_8.Models.Home;
using MVC_8.Models.ViewModels;

namespace MVC_8.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return Redirect("/About");
        }
    }
}
