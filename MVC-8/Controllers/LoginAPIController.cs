using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace MVC_8.Controllers
{
    public class AuthorixationAPICOntroller : Controller
    {
        public IActionResult Index()
        {
            //Areas_Identity_Pages_Account_ExternalLogin
            return View();
        }
    }
}
