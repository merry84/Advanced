namespace GenericSwapMethodInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
#pragma warning disable CS8604 // Possible null reference argument.
            int n = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
             Box<int> box = new Box<int>();
            for (int i = 0; i < n; i++)
            {
#pragma warning disable CS8604 // Possible null reference argument.
                int number = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
                box.Add(number);
            }

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            int[] command = Console.ReadLine()
                    .Split()
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
