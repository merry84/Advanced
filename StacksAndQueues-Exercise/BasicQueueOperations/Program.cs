namespace BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] operation = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] numbersLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> queue = new Queue<int>(numbersLine);

            for (int i = 0; i < operation[1]; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(operation[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Any())
                {
                    Console.WriteLine(queue.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
