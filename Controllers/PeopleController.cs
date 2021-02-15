using System.Collections.Generic;
using System.Linq;
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
        
        [HttpGet]
        public IActionResult Index()
        {
            var personen = GetPeople();
            
            return View(personen);
        }

        public IList<Person> GetPeople()
        {
            return _database.People;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            person.Id = GetNewId();
            _database.People.Add(person);

            return RedirectToAction("Index");
        }

        private int GetNewId()
        {
            if (_database.People.Any())
            {
                var getMaxId = _database.People.Max(p => p.Id);
                return getMaxId += 1;
            }
            else
            {
                return 1;
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var databasePerson = _database.People.SingleOrDefault(p => p.Id == id);

            return View(databasePerson);
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            var databasePerson = _database.People.SingleOrDefault(p => p.Id == person.Id);

            if (databasePerson == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                databasePerson.Naam = person.Naam;
                databasePerson.Adres = person.Adres;

                return RedirectToAction("Index");
            }
        }
        
        [HttpPost]
        [Route("People/Delete/{id?}")]
        public IActionResult Delete(int id)
        {
            var databasePerson = _database.People.SingleOrDefault(p => p.Id == id);
            if (databasePerson == null)
            {
                return RedirectToAction("Index");
            }
            
            _database.People.Remove(databasePerson);
            return RedirectToAction("Index");
        }
        
    }
}