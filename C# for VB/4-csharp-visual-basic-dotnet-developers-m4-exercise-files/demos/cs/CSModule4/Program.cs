using System;
using System.Linq;
using System.Collections.Generic;

namespace CSModule4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            people.Add(new Person("John Sonmez", "@jsonmez"));
            people.Add(new Person("Dan Wahlin", "@danwhalin"));
            people.Add(new Person("John Papa", "@john_papa"));
            people.Add(new Person("Craig Shoemaker", "@craigshoemaker"));
            people.Add(new Person("Julie Lerman", "@julielerman"));

            var query = from p in people
                        where p.Name.StartsWith("John")
                        select p;

            List<Person> results = query.ToList();

            foreach (Person person in results)
            {
                Console.WriteLine(person.Name);
            }



            Console.ReadLine();
        }
    }
}
