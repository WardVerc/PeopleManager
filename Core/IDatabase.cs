using System.Collections.Generic;
using PeopleManager.Models;

namespace PeopleManager.Core
{
    public interface IDatabase
    {
        IList<Person> People { get; set; }
        void Initialize();
    }
}