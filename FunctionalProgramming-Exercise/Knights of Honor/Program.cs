namespace Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string>nameList = Console.ReadLine()
               .Split(" ")
               .ToList();
           Action<string> appendNames = name => Console.WriteLine("Sir " + name);
           nameList.ForEach(appendNames);
        }
    }
}
