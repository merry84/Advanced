namespace PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(" ");
            Action<string[], int> printNameLine = (nameList, filter) =>
            {
                foreach (string name in nameList)
                {
                    if (name.Length <= filter)
                    {
                        Console.WriteLine(name);
                    }
                }
            };
            printNameLine(names, count);
        }
    }
}
