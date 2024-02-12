using System.Runtime.InteropServices.ComTypes;

namespace Masterchef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingredients = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Stack<int> freshness = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            //Dipping sauce	150
            // Green salad	250
            // Chocolate cake	300
            // Lobster	400

            Dictionary<string, int> dishes = new Dictionary<string, int>();
            dishes.Add("Dipping sauce", 0);
            dishes.Add("Green salad", 0);
            dishes.Add("Chocolate cake", 0);
            dishes.Add("Lobster", 0);
            while (ingredients.Any() && freshness.Any())
            {
                int ingredient = ingredients.Peek();
                int freshLevel = freshness.Peek();
                int totalFreshness = ingredient * freshLevel;

                if (ingredients.Count == 0 || freshness.Count == 0)
                {
                    break;
                }
                if (ingredients.Peek() == 0)
                {
                    ingredients.Dequeue();
                    continue;
                }
                if (totalFreshness == 150)
                {
                    dishes["Dipping sauce"]++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (totalFreshness == 250)
                {
                    dishes["Green salad"]++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (totalFreshness == 300)
                {
                    dishes["Chocolate cake"]++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (totalFreshness == 400)
                {
                    dishes["Lobster"]++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else
                {  
                    ingredients.Dequeue();
                    ingredients.Enqueue(ingredient +5);
                    freshness.Pop();
                }
            }
          

            if (dishes.Count >= 4)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }

            if (ingredients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }
            foreach (var itemDish in dishes.OrderBy(x => x.Key))
            {
                if (itemDish.Value > 0)
                {
                    Console.WriteLine($" # {itemDish.Key} --> {itemDish.Value}");

                }
            }


            //Console.WriteLine(" # {dish name} --> {amount});

        }
    }
}
