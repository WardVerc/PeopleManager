using Microsoft.AspNetCore.Mvc;

namespace PeopleManager.Controllers
{
    public class PeopleController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}