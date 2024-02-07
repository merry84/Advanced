﻿namespace ActionPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(" ")
                .ToList();
            Action<string> print = name => Console.WriteLine(name);
            names.ForEach(print);
        }
    }
}
