using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace Scheduling
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //It takes the first given thread value and the last given task value.
            Stack<int> tasks = new Stack<int>(Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray());
            Queue<int> threads = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray());
            int taskKilled = int.Parse(Console.ReadLine());


            //while (true) и това работи!!!
            //{
            //    int taskValue = tasks.Peek();
            //    int threadValue = threads.Peek();
            //    //It takes the first given thread value and the last given task value.
            //    if (taskValue == taskKilled) break;//спрете работата на процесора веднага щом стигнете до тази задача, в противен случай вашият процесор ще се срине.
            //    //If the thread value is greater than or equal to the task value, the task and thread get removed.
            //    tasks.Pop();
            //    threads.Dequeue();

            //    if (threadValue < taskValue) tasks.Push(taskValue);//If the thread value is less than the task value, the thread gets removed, but the task remains.

            //}
            while (tasks.Peek() != taskKilled)
            {
                if (threads.Peek() >= tasks.Peek())
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else
                {
                    threads.Dequeue();
                }
            }
            Console.WriteLine($"Thread with value {threads.Peek()} killed task {taskKilled}");

            Console.WriteLine(string.Join(" ", threads));
        }
    }
}
