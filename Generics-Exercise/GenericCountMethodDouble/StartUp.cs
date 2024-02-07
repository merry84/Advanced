namespace GenericCountMethodDouble
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<double>box = new Box<double>();
            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                box.Add(number);
            }

            double numberToCompare = double.Parse(Console.ReadLine());
            Console.WriteLine(box.GetCount(numberToCompare));
        }
    }
}
