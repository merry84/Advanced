namespace CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();
            Dictionary<double, int> counts = new Dictionary<double, int>();
            foreach (var number in numbers)
            {

                if (!counts.ContainsKey(number))//ако не съдържа числото
                {
                    counts[number] = 1;//записваме го 
                }
                else
                {
                    counts[number]++;// увеличаваме бр пъти когато сме го срещнали
                }
            }

            foreach (var numCount in counts)
            {
                Console.WriteLine($"{numCount.Key} - {numCount.Value} times");
            }
        }
    }
}
