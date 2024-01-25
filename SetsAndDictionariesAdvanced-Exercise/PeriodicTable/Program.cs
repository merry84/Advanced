namespace PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string>elements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] chElements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                elements.UnionWith(chElements);//добавя всички елементи от масива chaelements в сета
            }

            Console.WriteLine(string.Join(" ", elements));

        }
    }
}
