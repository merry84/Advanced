namespace PredicateParty_
{
    internal class Program
    {
        static void Main()
        {
            List<string> people = Console.ReadLine().Split(" ").ToList();
            string action;
            while ((action = Console.ReadLine()) != "Party!")
            {
                string[] command = action.Split().ToArray();
                string act = command[0];
                string criterie = command[1];
                string component = command[2];
                var predicate = GetPredicate(criterie, component);
                if (act == "Double")
                {
                    var names = people.FindAll(predicate);
                    foreach (var name in names)
                    {
                        int index = people.IndexOf(name);
                        people.Insert(index, name);
                    }
                }
                else if (act == "Remove")
                {
                    people.RemoveAll(predicate);
                }
            }
            if (people.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static Predicate<string> GetPredicate(string criterie, string component)
        {
            if (criterie == "StartsWith")
            {
                return p => p.StartsWith(component);
            }
            else if (criterie == "EndsWith")
            {
                return p => p.EndsWith(component);
            }
            else if (criterie == "Length")
            {
                return p => p.Length == int.Parse(component);
            }
            return default;

        }
    }
}
