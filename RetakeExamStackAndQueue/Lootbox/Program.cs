using System.Security.Claims;

namespace Lootbox
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //You need to start from the first item in the first box and sum it up with the last item in the second box.
            Queue<int>firstBox = new Queue<int>(Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Stack<int> secondBox = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            List<int> claimedItems = new List<int>();
            //If the sum of their values is an even number, add the summed item to your collection of claimed items and remove them both from the boxes.
            while (firstBox.Any() && secondBox.Any())
            {
                int fItem = firstBox.Peek();
                int sItem = secondBox.Peek();
                if ((fItem + sItem) % 2 == 0)
                {
                    claimedItems.Add(fItem+sItem);
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    secondBox.Pop();
                    firstBox.Enqueue(sItem);
                }
            }
            //If the first loot box becomes empty:
            if (!firstBox.Any())
            {
                Console.WriteLine("First lootbox is empty");
            }

            if (!secondBox.Any())
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (claimedItems.Sum() >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedItems.Sum()}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedItems.Sum()}");
            }
            // string result = claimedItems.Sum() >= 100 ? $"Your loot was epic! Value: {claimedItems.Sum()}" : $"Your loot was poor... Value: {claimedItems.Sum()}";
            //            Console.WriteLine(result);
        }
    }
}
