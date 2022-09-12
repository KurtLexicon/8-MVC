using Microsoft.AspNetCore.Mvc;

namespace MVC_8.Controllers {
    public class AboutController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
