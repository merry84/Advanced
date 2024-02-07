namespace DefiningClasses
{
    public class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name,age);
                persons.Add(person);
            }

            var sortPeople = persons
                .Where(n => n.Age > 30)
                .OrderBy(n => n.Name).ToList();
            foreach (var people in sortPeople)
            {
              Console.WriteLine($"{people.Name} - {people.Age}");
            }
        }
    }
}
