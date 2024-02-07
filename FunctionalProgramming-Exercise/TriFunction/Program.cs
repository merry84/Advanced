namespace TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            Func<string, int, bool> checkNameSum = (name, sum) => name.Sum(ch => ch) >= sum;
           

            Func<string[], int, Func<string, int, bool>, string> getFirstName = (names, sum, match) => names.FirstOrDefault(name => match(name, sum));
            //returns the first name, whose sum of characters is equal to or larger than a given number 

            Console.WriteLine(getFirstName(names, n, checkNameSum));
        }
    }
}
