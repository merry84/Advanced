using System;

namespace OffroadChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int>fuel = new Stack<int>(Console.ReadLine()//първоначалното гориво
                .Split()
                .Select(int.Parse));
            Queue<int>consumptionIndexes = new Queue<int>(Console.ReadLine()//допълнителен индекс на потребление
                .Split()
                .Select(int.Parse));
            Queue<int> altitude = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));// количество гориво, необходимо за достигане на съответната надморска височина

            List<string> altitudesReached = new List<string>();
            int countAltitude = 0;
            while (fuel.Any() && consumptionIndexes.Any())//take the last fuel quantity from the fuel sequence and the first index from the additional consumption index sequence.
            {
                countAltitude++;
                int currentFuel = fuel.Peek() - consumptionIndexes.Peek();//Subtract the values and check the result.
                if (currentFuel >= altitude.Peek())//remove both the fuel and the consumption index from their sequences as well as the needed amount of fuel index from their sequence.
                {
                    fuel.Pop();
                    consumptionIndexes.Dequeue();
                    altitude.Dequeue();
                    // Ако достигне надморската височина:
                    Console.WriteLine($"John has reached: Altitude {countAltitude}");
                    altitudesReached.Add($"Altitude {countAltitude}");
                }
                else
                {
                    Console.WriteLine($"John did not reach: Altitude {countAltitude}");
                    break;
                }
                
                if (altitude.Count == 0)// Ако успее да достигне всички височини, той ще достигне върха.:
                {
                    Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
                    //Environment.Exit(0);// прекратява програмата
                    return;
                }
               
            }
            if (altitudesReached.Count > 0)//Ако няма достатъчно гориво, за да стигне до върха, но е достигнал известна надморска височина
            {
                Console.WriteLine($"John failed to reach the top.");
                Console.WriteLine($"Reached altitudes: {string.Join(", ", altitudesReached)}");
            }
            else if (altitudesReached.Count == 0)// Ако няма достатъчно гориво, за да стигне до върха и не е достигнал никаква надморска височина:
            {
                Console.WriteLine("John failed to reach the top.");
                Console.WriteLine("John didn't reach any altitude.");
            }

            // Ако Джон няма достатъчно гориво, за да стигне до върха, но е достигнал известна надморска височина, покажете следните съобщения:
        }
    }
}
