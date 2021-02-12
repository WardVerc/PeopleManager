using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PeopleManager.Models;

namespace PeopleManager.Controllers
{
    public class PeopleController : Controller
    {
        // GET
        public IActionResult Index()
        {
            IEnumerable<Person> personen = new List<Person>();
            personen = Person.maakData();
            return View(personen);
        }
    }
}