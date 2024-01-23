namespace Jagged_ArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] array = new int[rows][];
            for (int row = 0; row < array.Length; row++)
            {
                array[row] = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            }
            string command = Console.ReadLine().ToLower();
                
            while (command != "end")
            {
                string[] argument = command.Split(' ');
                int row = int.Parse(argument[1]);
                int col = int.Parse(argument[2]);
                int value = int.Parse(argument[3]);
                if (row < 0 || row >= array.Length
                            || array[row].Length <= col
                            || col < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (argument[0] == "add")
                {
                    array[row][col] += value;
                }
                else if (argument[0] == "subtract")
                {
                    array[row][col] -= value;
                }
                command = Console.ReadLine().ToLower();
            }

            for (int row = 0; row < array.Length; row++)
            {
                for (int col = 0; col < array[row].Length; col++)
                {
                    Console.Write(array[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
