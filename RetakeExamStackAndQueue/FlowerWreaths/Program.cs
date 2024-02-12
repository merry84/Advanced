using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerWreaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You will start crafting from the last lilies and the first roses. 
            //•	On the first line, you will receive the integers representing the lilies, separated by ", ".
            // •On the second line, you will receive the integers representing the roses, separated by ", ".
            Stack<int> lilies = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Queue<int> roses = new Queue<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            int flowersCount = 0;
            int wreaths = 0;
            while (true)
            {
                if (!lilies.Any() || !roses.Any()) break;

                int lilie = lilies.Peek();
                int rose = roses.Peek();

                if (lilie + rose > 15)
                {
                    lilies.Push(lilies.Pop() - 2);
                    continue;
                }
                else if (lilie + rose < 15) flowersCount = flowersCount + lilie + rose;

                else wreaths++;

                lilies.Pop();
                roses.Dequeue();

            }
            wreaths += flowersCount / 15;
            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }

            else
            {
                Console.WriteLine($"You didn't make it, you need {Math.Abs(5 - wreaths)} wreaths more!");
            }
        }
    }
}