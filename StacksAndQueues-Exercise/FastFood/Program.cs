namespace FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[]orders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(orders);
            Console.WriteLine(queue.Max());

            while (queue.Count > 0)
            {
                if(quantity - queue.Peek() >= 0)
                {
                    quantity-= queue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
