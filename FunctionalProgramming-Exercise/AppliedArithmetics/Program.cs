using System.Buffers;

namespace AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*•	"add" -> add 1 to each number
               •	"multiply" -> multiply each number by 2
               •	"subtract" -> subtract 1 from each number
               •	"print" -> print the collection
               •	"end" -> ends the input 
               */
            List<int>numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            Action<List<int>> printList = list => Console.WriteLine(string.Join(" ",list));

            Func<List<int>, List<int>> operation = null;
            string command ;
            while ((command= Console.ReadLine()) !="end")
            {
                if (command == "add")
                {
                    operation = list => list.Select(number=>number+=1).ToList();
                    numbers = operation(numbers);
                }
                else if (command == "multiply")
                {
                    operation = list => list.Select(number => number *= 2).ToList();
                    numbers = operation(numbers);
                }
                else if (command == "subtract")
                {
                    operation = list => list.Select(number => number -= 1).ToList();
                    numbers = operation(numbers);
                }
                else if (command == "print")
                {
                    printList(numbers);
                }
            }
        }
    }
}
