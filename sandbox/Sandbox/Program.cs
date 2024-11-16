using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Person p1 = new Person();
        p1._firstName = "Moise";
        p1._lastname = "Ntallah";
        p1._age = 31;

        Person p2 = new Person();
        p2._firstName = "Yves";
        p2._lastname = "Choutvet";
        p2._age = 39;

        List<Person> people = new List<Person>();
        people.Add(p1);
        people.Add(p2);

        foreach (Person p in people)
        {
            Console.WriteLine(p._firstName);
        }

        SaveToFile(people);

        List<Person> newPeople = ReadFromFile();
        foreach(Person p in newPeople)
        {
            Console.WriteLine(p._lastname);
        }
    }

    public static void SaveToFile(List<Person> people)
    {
        Console.WriteLine("Saving to file....");
        string filename = "people.txt";

        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (Person p in people)
            {
                outputfile.WriteLine($"{p._firstName}~~{p._lastname}~~{p._age}");
            }
        }
    }

    public static List<Person> ReadFromFile()
    {
        Console.WriteLine("Reading list from file....");
        List<Person> people = new List<Person>();
        string filename = "people.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach(string line in lines)
        {
            string[] parts = line.Split("~~");

            Person newPerson = new Person();
            newPerson._firstName = parts[0];
            newPerson._lastname = parts[1];
            newPerson._age = int.Parse(parts[2]);

            people.Add(newPerson);
        }

        return people;
    }
}