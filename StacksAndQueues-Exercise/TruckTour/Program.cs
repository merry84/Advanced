namespace TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pumpsCount = int.Parse(Console.ReadLine());

            Queue<int[]>pumpsQueue = new Queue<int[]>();
            for (int i = 0; i < pumpsCount; i++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
               int amountLitre = input[0];
               int distance = input[1];
               pumpsQueue.Enqueue(input);
            }
            int bestTour = 0;
            while (true)
            {
                int allLitre = 0;
                foreach (int[] pump in pumpsQueue)
                {
                    allLitre += pump[0];
                    int currentDistance = pump[1];

                    if (allLitre - currentDistance < 0)
                    {
                        allLitre = 0;
                        break;
                    }
                    else
                    {
                        allLitre-= currentDistance;
                    }
                }
                if (allLitre > 0)
                {
                    break;
                }
                bestTour++;
                pumpsQueue.Enqueue(pumpsQueue.Dequeue());
            }
            Console.WriteLine(bestTour);
        }
    }
}
