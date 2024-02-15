using System.Runtime.InteropServices;

namespace FishingCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int currentRow = -1;
            int currentColumn = -1;
            int quantity = 0;

            for (int i = 0; i < size; i++)
            {
                char[] newRow = Console.ReadLine().ToCharArray();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = newRow[j];
                    if (newRow[j] == 'S')
                    {
                        currentRow = i;
                        currentColumn = j;
                       

                    }
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "collect the nets")

            {
                matrix[currentRow, currentColumn] = '-';
                currentRow = ResetRowAndCol(command, currentRow, matrix, ref currentColumn);

                if (char.IsDigit(matrix[currentRow, currentColumn]))
                {
                    quantity += matrix[currentRow, currentColumn] - '0';
                    
                }
                else if (matrix[currentRow, currentColumn] == 'W')
                {
                    Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{currentRow},{currentColumn}]");
                    Environment.Exit(0);
                }

            }

            matrix[currentRow, currentColumn] = 'S';
            if (quantity >= 20)
            {
                Console.WriteLine("Success! You managed to reach the quota!");
            }
            else
            {
                Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {(20 - quantity)} tons of fish more.");
            }
            if (quantity > 0) { Console.WriteLine($"Amount of fish caught: {quantity} tons."); }
            PrintMatrix(matrix);
        }

        private static int ResetRowAndCol(string? command, int currentRow, char[,] matrix, ref int currentColumn)
        {//Example: In a 3x3 matrix you are at position [1,2] and receive the command "right" you will be moved to position [1,0]. 
            if (command == "up")
            {
                if (currentRow - 1 >= 0)
                {
                    currentRow--;
                }
                else
                {
                    currentRow = matrix.GetLength(0) - 1;
                }

            }
            else if (command == "down")
            {
                if (currentRow + 1 < matrix.GetLength(0))
                {
                    currentRow++;
                }
                else
                {
                    currentRow = 0;
                }
            }

            if (command == "left")
            {
                if (currentColumn - 1 >= 0)
                {
                    currentColumn--;
                }
                else
                {
                    currentColumn = matrix.GetLength(1) - 1;
                }

            }
            else if (command == "right")
            {
                if (currentColumn + 1 < matrix.GetLength(1))
                {
                    currentColumn++;
                }
                else
                {
                    currentColumn = 0;
                }
            }

            return currentRow;
        }
        
        
        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
