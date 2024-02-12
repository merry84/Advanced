using System;
using System.Text.RegularExpressions;

namespace WormsAndHoles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> worms = new Stack<int>(Console.ReadLine() //червей
                .Split(" ")
                .Select(int.Parse));
            Queue<int> holes = new Queue<int>(Console.ReadLine()//дупка
                .Split(" ")
                .Select(int.Parse));

            int match = 0;
            int matchHoles = worms.Count;
            while (worms.Count > 0 && holes.Count > 0)
            {
                int worm = worms.Peek();
                int hole = holes.Peek();
                //If their values are equal, the worm fits the hole and can get into it. After that, you should remove both of them from their sequences
                if (worm == hole)
                {
                    worms.Pop();
                    holes.Dequeue();
                    match++;
                    continue;
                }
                //Otherwise, you should remove the hole and decrease the value of the worm by 3.
                holes.Dequeue();
                worms.Push(worms.Pop()-3);
                //If the worm value becomes equal to or below 0, remove it from the sequence before trying to match it with the hole. 
                if (worms.Peek() <= 0)
                {
                    worms.Pop();
                }
            }
            //	If there are matches print the following: 
            if (match != 0)
            {
                Console.WriteLine($"Matches: {match}");
            }
            else
            {
                Console.WriteLine("There are no matches.");
            }
            //If there are no worms left and all of them fit a hole:
            if (worms.Count == 0 && matchHoles == match)
            {
                Console.WriteLine("Every worm found a suitable hole!");
            }
            else if (worms.Count == 0)//If there are no worms left but only some of them fit a hole:
            {
                Console.WriteLine("Worms left: none");
            }
            else //If there are worms left:
            {
                Console.WriteLine("Worms left: " + string.Join(", ", worms));
            }
            //If there are no holes left:

            if (holes.Count == 0)
            {
                Console.WriteLine("Holes left: none");
            }
            else
            {
                Console.WriteLine("Holes left: " + string.Join(", ", holes));
            }
        }
    }
}
