using OldestFamilyMember;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split(" ");

                string name = elements[0];
                int age = int.Parse(elements[1]);

                Person person = new Person(name,age);
                family.AddMember(person);
            }

            Person oldPerson = family.GetOldestMember();
            Console.WriteLine($"{oldPerson.Name} {oldPerson.Age}");
        }
    }
}
