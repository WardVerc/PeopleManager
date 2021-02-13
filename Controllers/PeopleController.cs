using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PeopleManager.Core;
using PeopleManager.Models;

namespace PeopleManager.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IDatabase _database;

        public PeopleController(IDatabase database)
        {
            _database = database;
        }
        public IActionResult Index()
        {
            var personen = GetPeople();
            
            return View(personen);
        }

        public IList<Person> GetPeople()
        {
            return _database.People;
        }
    }
}