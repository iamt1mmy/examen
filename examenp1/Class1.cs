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

class Program
{
    static void Main()
    {
        Console.Write("Numarul de persoane: ");
        int numarPersoane = int.Parse(Console.ReadLine());

        Person[] persoane = new Person[numarPersoane];

        for (int i = 0; i < numarPersoane; i++)
        {
            Console.WriteLine($"Introduceti informatii pentru persoana {i + 1}:");
            Console.Write("Prenume: ");
            string prenume = Console.ReadLine();

            Console.Write("Nume de familie: ");
            string nume = Console.ReadLine();

            Console.Write("Anul nasterii: ");
            int anNastere = int.Parse(Console.ReadLine());

            persoane[i] = new Person
            {
                FirstName = prenume,
                LastName = nume,
                YearOfBirth = anNastere
            };
        }
        Person ceaMaiInVarsta = PersonProcessor.GetOldestPerson(persoane);

        Console.WriteLine($"\nPersoana cea mai varstnica este:");
        Console.WriteLine($"Prenume: {ceaMaiInVarsta.FirstName}");
        Console.WriteLine($"Nume de familie: {ceaMaiInVarsta.LastName}");
        Console.WriteLine($"Anul nasterii: {ceaMaiInVarsta.YearOfBirth}");
        Console.WriteLine($"Varsta: {ceaMaiInVarsta.Age} ani");
    }
}