using System;
using System.Collections.Generic;

namespace EnumForEach
{
    public class Person
    {
        public Person(string fName, string lName)
        {
            this.firstName = fName;
            this.lastName = lName;
        }

        public string firstName;
        public string lastName;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person[] peopleArray = new Person[3]
        {
            new Person("John", "Smith"),
            new Person("Jim", "Johnson"),
            new Person("Sue", "Rabon"),
        };
            List<Person> x = new List<Person>();
            x.Add(new Person("John", "Smith"));
            x.Add(new Person("Jim", "Smith"));
            x.Add(new Person("Sue", "Smith"));

            foreach (Person p in x)
                Console.WriteLine(p.firstName + " " + p.lastName);
        }
    }
}
