namespace GenericBoxOfInteger
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
#pragma warning disable CS8604 // Possible null reference argument.
           int n = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
            var box = new Box<int>();
            for (int i = 0; i < n; i++)
            {
#pragma warning disable CS8604 // Possible null reference argument.
                int number = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
                box.Add(number);

            }
            Console.WriteLine(box);
        }
    }
}
