namespace ThePartyReservationFilterModule
{
    internal class Program
    {
        static void Main()
        {
            List<string> people = Console.ReadLine().Split(" ").ToList();
            var filters = new Dictionary<string, Predicate<string>>();
            string action;
            while ((action = Console.ReadLine()) != "Print")
            {
                string[] command = action.Split(";").ToArray();
                string act = command[0];
                string criterie = command[1];
                string component = command[2];

                var predicate = GetPredicate(criterie, component);

                if (act == "Add filter")
                {
                    filters.Add(criterie + component, predicate);
                }
                else if (act == "Remove filter")
                {
                    filters.Remove(criterie + component);
                }
            }
            foreach (var filter in filters)
            {
                people.RemoveAll(filter.Value);
            }
            people.ForEach(person => Console.Write(person + " "));
        }



        private static Predicate<string> GetPredicate(string criterie, string component)
        {
            if (criterie == "Starts with")
            {
                return p => p.StartsWith(component);
            }
            else if (criterie == "Ends with")
            {
                return p => p.EndsWith(component);
            }
            else if (criterie == "Length")
            {
                return p => p.Length == int.Parse(component);
            }
            else if (criterie == "Contains")
            {
                return p => p.Contains(component);
            }
            return default;

        }
    }
}
