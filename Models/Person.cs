using System.Collections.Generic;

namespace PeopleManager.Models
{
    public class Person
    {
        public string Naam { get; set; }
        public string Adres { get; set; }
        
        public int Id { get; set; }


        public static IEnumerable<Person> maakData()
        {
            var person1 = new Person()
            {Naam = "Ward", Adres = "Hundelgemsesteenweg", Id = 1};
            var person2 = new Person()
            {Naam = "Michiel", Adres = "Voordries", Id = 2};
            var person3 = new Person()
            {Naam = "Filip", Adres = "Ergens in Aalst", Id = 3};

            var personenLijst = new List<Person>();
            personenLijst.Add(person1);
            personenLijst.Add(person2);
            personenLijst.Add(person3);

            return personenLijst;

        }
    }
}