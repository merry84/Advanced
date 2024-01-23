namespace BasicStackOperations
{
    internal class Program
    {
        public static bool True { get; private set; }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int s = int.Parse(input[1]);
            int x = int.Parse(input[2]);

            string[] numberLine = Console.ReadLine().Split();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(numberLine[i]);
                stack.Push(number);

            }
            for (int i = 0; i < s; i++)
            {
                stack.Pop();

            }
            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (stack.Any())
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
