using System.Collections.Generic;

namespace PeopleManager.Models
{
    public class Person
    {
        public string Naam { get; set; }
        public string Adres { get; set; }


        public static IEnumerable<Person> maakData()
        {
            var person1 = new Person()
            {Naam = "Ward", Adres = "Hundelgemsesteenweg"};
            var person2 = new Person()
            {Naam = "Michiel", Adres = "Voordries"};
            var person3 = new Person()
            {Naam = "Filip", Adres = "Ergens in Aalst"};

            var personenLijst = new List<Person>();
            personenLijst.Add(person1);
            personenLijst.Add(person2);
            personenLijst.Add(person3);

            return personenLijst;

        }
    }
}