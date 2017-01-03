using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>();

            people.Add(new Person("Juan Arriaga", "@arriagar"));
            people.Add(new Person("John Smith", "@jsmith"));

            foreach (Person person in people)
            {
                Console.WriteLine(person.Name);
            }

            //Workflow<SetupWorkflow> workflow = new Workflow<SetupWorkflow>();
            Workflow workflow = new Workflow();

            workflow.Process<SetupWorkflow>(new SetupWorkflow());


            Console.ReadLine();            
        }
    }
}
