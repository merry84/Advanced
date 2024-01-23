using System.Data.Common;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>(input.Reverse());
            int sumExpression = int.Parse(stack.Pop());

            while (stack.Count > 0)
            {
                string operation = stack.Pop();
                int number = int.Parse(stack.Pop());
                if (operation == "+")
                {
                    sumExpression += number;
                }
                else
                {
                    sumExpression -= number;
                }
            }
            Console.WriteLine(sumExpression);
        }
    }
}
