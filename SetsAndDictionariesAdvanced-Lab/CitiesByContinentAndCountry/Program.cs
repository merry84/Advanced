namespace CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var places = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < count; i++)
            {
            
                string[] list = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = list[0];
                string country = list[1];
                string city = list[2];

                if (!places.ContainsKey(continent))//ако не съществува този континент
                {
                    places.Add(continent, new Dictionary<string, List<string>>());//създай и го запиши
                }

                if (!places[continent].ContainsKey(country))// на този континент ако няма такава държава
                {
                    places[continent].Add(country,new List<string>());//съдай и  го запиши
                }
                places[continent][country].Add(city);// ако има континент и държава добави този град
                
            }

            foreach (var items in places)
            {
                Console.WriteLine($"{items.Key}:");
                foreach (var item in items.Value)
                {
                    Console.WriteLine($"\t{item.Key} -> {string.Join(", ",item.Value)}");// \t - табулация = на два интервала
                }

            }
        }
    }
}
