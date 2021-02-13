using System.Collections.Generic;
using PeopleManager.Models;

namespace PeopleManager.Core
{
    public class Database : IDatabase
    {
        public IList<Person> People { get; set; }
        
        public Database()
        {
            People = new List<Person>();
        }

        public void Initialize()
        {
            People = new List<Person>
            {
                new Person {Naam = "Ward", Adres = "Hundelgemsesteenweg", Id = 1},
                new Person {Naam = "Michiel", Adres = "Voordries", Id = 2},
                new Person {Naam = "Filip", Adres = "Ergens in Aalst", Id = 3}
            };
        }
        
    }
}