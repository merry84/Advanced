﻿namespace MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n =int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (input[0]== 1)
                {
                    stack.Push(input[1]);
                }
                else if (input[0]== 2)
                {
                    stack.Pop();
                }
                else if (input[0]== 3 && stack.Any())
                {
                    Console.WriteLine(stack.Max());
                }
                else if (input[0]== 4 && stack.Any())
                {
                    Console.WriteLine(stack.Min());
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
