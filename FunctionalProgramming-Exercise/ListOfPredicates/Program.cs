namespace ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());//10 -> 1,2,3,4,5,6,7,8,9,10
            List<int> dividers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();//1 1 1 2
            List<int> numbers = new List<int>();
            for (int i = 1; i <= range; i++)
            {
                numbers.Add(i);
            }
            foreach (int number in dividers)
            {
                Func<int, bool> func = n => n % number == 0;
                numbers = numbers.Where(func).ToList();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
