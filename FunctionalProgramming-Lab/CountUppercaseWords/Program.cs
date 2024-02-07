namespace CountUppercaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)//има излишни интервали
                 .Where(x => char.IsUpper(x[0]))
                 .ToList();
            text.ForEach(t => Console.WriteLine(t));// foreach

        }
    }
}
