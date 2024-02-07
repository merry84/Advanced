namespace GenericSwapMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
#pragma warning disable CS8604 // Possible null reference argument.
            int n = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
            var box = new Box<string>();
            for (int i = 0; i < n; i++)
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string input = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.
                box.Add(input);
#pragma warning restore CS8604 // Possible null reference argument.
            }
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            int[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            int first = command[0];
            int second = command[1];
            box.Swap(first,second);
            Console.WriteLine(box);
        }

    }
}
