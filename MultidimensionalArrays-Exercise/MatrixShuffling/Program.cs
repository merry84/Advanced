using System.Security.Cryptography.X509Certificates;

namespace MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] newRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = newRow[col];
                }
            }
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (!IsValidCommand(arguments, matrix))//If the command is not valid 
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                //You should swap the values at the given coordinates (cell [row1, col1] with cell [row2, col2]) 
                int row1 = int.Parse(arguments[1]);
                int col1 = int.Parse(arguments[2]);
                int row2 = int.Parse(arguments[3]);
                int col2 = int.Parse(arguments[4]);

                (matrix[row1, col1], matrix[row2, col2]) = (matrix[row2, col2], matrix[row1, col1]);

                PrintMatrix(matrix);
            }
        }
        static bool IsValidCommand(string[] arguments, string[,] matrix)
        {
            if (arguments[0] != "swap" || arguments.Length != 5)
            {
                return false;
            }
            int row1 = int.Parse(arguments[1]);
            int col1 = int.Parse(arguments[2]);
            int row2 = int.Parse(arguments[3]);
            int col2 = int.Parse(arguments[4]);

            return row1 >= 0 && row1 < matrix.GetLength(0)
                             && row2 >= 0 && row2 < matrix.GetLength(0)
                             && col1 >= 0 && col1 < matrix.GetLength(1)
                             && col2 >= 0 && col2 < matrix.GetLength(1);
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
