using System;
using System.Collections.Generic;

namespace Nissim.On.Iterator
{
    class Program
    {
        //Use IEnumerable and IEnumerator of .NET
        //For Generic : Create Interfaces of Iterable and Iterator
        static void Main(string[] args)
        {
            List<Person> peopleArray = new List<Person>
            {
                new Person("John", "Smith"),
                new Person("Jim", "Johnson"),
                new Person("Sue", "Rabon"),
            };

            People peopleList = new People(peopleArray);
            foreach (Person p in peopleList)
                Console.WriteLine(p.FirstName + " " + p.LastName);
        }
    }
}
