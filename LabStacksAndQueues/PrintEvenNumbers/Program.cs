namespace PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> queue = new Queue<int>(numbers);
            string result = string.Empty;

            while(queue.Count > 0)
            {
                int number = queue.Dequeue();
                if (number % 2 == 0)
                {
                    result += $"{number}, ";
                }
            }
            Console.WriteLine(result.TrimEnd(' ', ','));
        }
    }
}
