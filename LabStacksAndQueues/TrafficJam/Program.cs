namespace TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var queueCar = new Queue<string>();
            int count = 0;
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < n && queueCar.Count > 0; i++)
                    {
                        string car = queueCar.Dequeue();
                        Console.WriteLine($"{car} passed!");
                        count++;
                    }

                }
                else
                {
                    queueCar.Enqueue(command);
                }
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
