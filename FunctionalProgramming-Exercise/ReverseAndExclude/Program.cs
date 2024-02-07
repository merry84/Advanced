namespace ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int deviser = int.Parse(Console.ReadLine());


            Predicate<int> predicate = p => p % deviser != 0;
            var finalList = numbers
                .Where(number => predicate(number))
                .ToArray();
            Console.WriteLine(string.Join(" ",finalList.Reverse()));
        }

    }
}
