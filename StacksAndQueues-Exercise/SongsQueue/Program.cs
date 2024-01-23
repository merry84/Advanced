namespace SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ")
                .ToArray();

            Queue<string> songQueue = new Queue<string>(songs);

            while (songQueue.Count > 0)
            {
                string[] command = Console.ReadLine()
                    .Split()
                    .ToArray();
                if (command[0] == "Play")
                {
                    songQueue.Dequeue();

                }
                else if (command[0] == "Add")//command[1]= songName
                {
                    command[1] = string.Join((" "), command.Skip(1));//Watch Me, Love Me Harder
                    if (songQueue.Contains(command[1]))
                    {
                        Console.WriteLine($"{command[1]} is already contained!");
                    }
                    else
                    {
                        songQueue.Enqueue(command[1]);
                    }
                }
                else//command == Show
                {
                    Console.WriteLine(string.Join(", ",songQueue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
