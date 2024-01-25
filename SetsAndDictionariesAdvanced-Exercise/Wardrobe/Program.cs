namespace Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"{color} -> {item1},{item2},{item3}…"

            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ",StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];

                if(!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color,new Dictionary<string, int>());
                }

                string[] clothes = input[1].Split(",");
                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(clothes[j]))
                    {
                        wardrobe[color].Add(clothes[j],1);
                        continue;
                    }
                    wardrobe[color][clothes[j]]++;
                }
            }
            string[] searchClothes = Console.ReadLine().Split(" ");
            string searchColor = searchClothes[0];
            string searchItem = searchClothes[1];
            /*  Blue clothes:
                * dress - 1 (found!)
                * jeans - 1
                * hat - 1
                * gloves - 1
            */
            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var item in color.Value)
                {
                    if (color.Key == searchColor 
                        && item.Key == searchItem)//If you find the item you are looking for, you need to print "(found!)"
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                        continue;
                    }

                    Console.WriteLine($"* {item.Key} - {item.Value}");
                }

            }

        }
    }
}
