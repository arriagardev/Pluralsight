namespace Generics
{
    class Person
    {
        public string Name { get; set; }
        public string Twitter { get; set; }

        public Person(string name, string twitter)
        {
            this.Name = name;
            this.Twitter = twitter;
        }
    }
}
