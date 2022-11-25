using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace MVC_8.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return Redirect("/About");
        }
    }
}
