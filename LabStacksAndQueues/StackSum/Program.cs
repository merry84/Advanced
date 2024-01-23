namespace StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            Stack<int> stack = new Stack<int>(input);
            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                string[] tokens = command.Split();
                int firstNumber = int.Parse(tokens[1]);
                if (tokens[0] == "add")
                {
                    int secondNumber = int.Parse(tokens[2]);
                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else if (tokens[0] == "remove")
                {
                    if (stack.Count >= firstNumber)
                    {
                        for (int i = 0; i < firstNumber; i++)
                        {
                            stack.Pop();

                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
/*
1 2 3 4
adD 5 6
REmove 3
eNd
 */