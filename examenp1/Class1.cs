using System;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int YearOfBirth { get; set; }

    public int Age
    {
        get
        {
            return DateTime.Now.Year - this.YearOfBirth;
        }
    }
}

public static class PersonProcessor
{
    public static Person GetOldestPerson(Person[] people)
    {
        if (people == null || people.Length == 0)
        {
            return null;
        }
        Person oldestPerson = people[0];
        foreach (Person person in people)
        {
            if (person.Age > oldestPerson.Age)
            {
                oldestPerson = person;
            }
        }
        return oldestPerson;
    }
}