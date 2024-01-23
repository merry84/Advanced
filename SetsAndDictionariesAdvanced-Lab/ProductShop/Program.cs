namespace ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shops = new SortedDictionary<string, Dictionary<string, double>>();

            string command;
            while ((command = Console.ReadLine()) != "Revision")
            {
                string[] commandArg = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shopName = commandArg[0];
                string product = commandArg[1];
                double price = double.Parse(commandArg[2]);

                if (!shops.ContainsKey(shopName))
                {
                    shops.Add(shopName, new Dictionary<string, double>());
                }
                shops[shopName].Add(product, price);
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var item in shop.Value)
                {

                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }

            }
        }
    }
}
