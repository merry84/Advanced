namespace SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = input[0];
            int m = input[1];

            HashSet<int>firstHashSet = new HashSet<int>();
            HashSet<int>secondHashSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                firstHashSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < m; i++)
            {
                secondHashSet.Add(int.Parse(Console.ReadLine()));
            }

            firstHashSet.IntersectWith(secondHashSet);

            Console.WriteLine(string.Join(" ",firstHashSet));
            
        }
    }
}
