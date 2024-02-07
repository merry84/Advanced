namespace FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string typeCommand = Console.ReadLine();

            Predicate<int>isEven = number=> number % 2 == 0;

            for (int i = input[0]; i <= input[1]; i++)
            {
                if (isEven(i) && typeCommand == "even")
                {
                    Console.Write(i + " ");
                }
                else if(!isEven(i)&& typeCommand == "odd")
                {
                    Console.Write(i + " ");
                }
            }
        }

    }
}
