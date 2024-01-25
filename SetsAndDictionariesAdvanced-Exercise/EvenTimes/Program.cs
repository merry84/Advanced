namespace EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int,int>evenNumber = new Dictionary<int,int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!evenNumber.ContainsKey(number))
                {
                    evenNumber.Add(number,1);
                    continue;
                }

                evenNumber[number]++;
            }
            Console.WriteLine(evenNumber
                .First(n=>n.Value % 2 ==0)// първото намерено четно
                .Key);//изпиши неговия ключ
        }

    }
}
