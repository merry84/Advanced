namespace AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> vatFunc = n => n * 1.2;
            double[] prices = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(vatFunc)
                .ToArray();
           foreach (var price in prices)
           {
               Console.WriteLine($"{price:f2}");
           }
           
        }
    }
}
