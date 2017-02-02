using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class PersonRepository
    {
        public List<Person> GetPeople()
        {
            //Person[] people =
            //{
            //    new Person() {FirstName="Juan", LastName="Perez", Registration= DateTime.Parse("12/01/1990"), Rating=10 },
            //    new Person() {FirstName="Luis", LastName="Lopez", Registration= DateTime.Parse("12/01/1985"), Rating=10 },
            //    new Person() {FirstName="Carlos", LastName="Sanchez", Registration= DateTime.Parse("12/01/1994"), Rating=10 },
            //    new Person() {FirstName="Francisco", LastName="Gomez", Registration= DateTime.Parse("12/01/1995"), Rating=10 },
            //    new Person() {FirstName="Fernando", LastName="Salinas", Registration= DateTime.Parse("12/01/1991"), Rating=10 },
            //    new Person() {FirstName="Ivan", LastName="Bonilla", Registration= DateTime.Parse("12/01/1985"), Rating=10 },
            //    new Person() {FirstName="Jose", LastName="Marquez", Registration= DateTime.Parse("12/01/1989"), Rating=10 },
            //    new Person() {FirstName="Mario", LastName="Patlan", Registration= DateTime.Parse("12/01/1990"), Rating=10 }
            //};

            List<Person> people = new List<Person>();
            people.Add(new Person() { FirstName = "Juan", LastName = "Perez", Registration = DateTime.Parse("12/01/1990"), Rating = 10 });
            people.Add(new Person() { FirstName = "Luis", LastName = "Lopez", Registration = DateTime.Parse("12/01/1985"), Rating = 10 });
            people.Add(new Person() { FirstName = "Carlos", LastName = "Sanchez", Registration = DateTime.Parse("12/01/1994"), Rating = 10 });
            people.Add(new Person() { FirstName = "Francisco", LastName = "Gomez", Registration = DateTime.Parse("12/01/1995"), Rating = 10 });
            people.Add(new Person() { FirstName = "Fernando", LastName = "Salinas", Registration = DateTime.Parse("12/01/1991"), Rating = 10 });
            people.Add(new Person() { FirstName = "Ivan", LastName = "Bonilla", Registration = DateTime.Parse("12/01/1985"), Rating = 10 });
            people.Add(new Person() { FirstName = "Jose", LastName = "Marquez", Registration = DateTime.Parse("12/01/1989"), Rating = 10 });
            people.Add(new Person() { FirstName = "Mario", LastName = "Patlan", Registration = DateTime.Parse("12/01/1990"), Rating = 10 });

            return people;
        }
    }
}
