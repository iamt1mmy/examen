namespace examenp1
{
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
}