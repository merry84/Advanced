using System;
using System.Data;
using System.Threading.Channels;

namespace FilterByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ReadPeople();
            string condition = Console.ReadLine();
            int ageThreshold = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<Person, bool> filter = CreateFilter(condition, ageThreshold);
            Action<Person> printer = CreatePrinter(format);
            PrintFilteredPeople(people, filter, printer);

        }

        private static List<Person> ReadPeople()
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] people = Console.ReadLine().Split(", ");
                string name = people[0];
                int age = int.Parse(people[1]);
                persons.Add(new Person(name,age));

            }
            return persons;
        }

        private static void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
        {
            List<Person> selectedPeople = people.Where(filter).ToList();
            selectedPeople.ForEach(printer);
        }

        static Func<Person,bool>CreateFilter(string condition, int ageThreshold)
        {
            if (condition == "younger")
            {
                return a => a.Age < ageThreshold;
            }
            else if (condition == "older")
            {
                return a=>a.Age >= ageThreshold;
            }

            throw new ArgumentException(condition);
        }

        static Action<Person> CreatePrinter(string format)
        {
            if (format == "name")
            {
                return f => Console.WriteLine(f.Name);
            }
            else if (format == "age")
            {
                return  f => Console.WriteLine(f.Age);
            }
            else if (format == "name age")
            {
                return f=> Console.WriteLine($"{f.Name} - {f.Age}");
            }

            throw new ArgumentException(format); 
        }
    }

    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
