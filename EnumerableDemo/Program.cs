using System;
using System.Collections;

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

public class People : IEnumerable
{
    private Person[] _people;
    public People(Person[] pArray)
    {
        _people = pArray;
      
    }

    //methods

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new PeopleEnum(_people);
    }

}

public class PeopleEnum : IEnumerator
{
    public Person[] _people;

    int position = -1;

    public PeopleEnum(Person[] list)
    {
        _people = list;
    }

    public bool MoveNext()
    {
        position++;
        Console.WriteLine("here");
        return (position < _people.Length);
    }

    public void Reset()
    {
        position = -1;
    }

    object IEnumerator.Current
    {
        get
        {
                return _people[position];
           
        }
    }

}


class App
{
    static void Main()
    {

        //explicitly coded

        Person[] peopleArray = new Person[3]
        {
            new Person("John", "Smith"),
            new Person("Jim", "Johnson"),
            new Person("Sue", "Rabon"),
        };

        People peopleList = new People(peopleArray);
        foreach (Person p in peopleList)
            Console.WriteLine(p.firstName + " " + p.lastName);

    }
}

