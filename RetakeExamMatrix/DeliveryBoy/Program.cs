using System.Drawing;
using System.Numerics;

namespace DeliveryBoy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            char[,] matrix = new char[size[0], size[1]];
            int boyRow = -1;
            int boyCol = -1;

            int startRow = -1;
            int startCol = -1;
            bool outMatrix = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] newRow = Console.ReadLine().ToCharArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = newRow[j];
                    if (matrix[i, j] == 'B')
                    {
                        boyRow = i; boyCol = j; startRow = j; startCol = j;
                    }
                }
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "left")
                {
                    if (boyCol > 0)// няма да излезне от полето
                    {
                        if (matrix[boyRow, boyCol - 1] == '*')
                        {
                            continue;
                        }
                        if (matrix[boyRow, boyCol] != 'R')
                        {
                            matrix[boyRow, boyCol] = '.';
                        }
                        boyCol--;

                    }
                    else
                    {
                        if (matrix[boyRow, boyCol] == '-')
                        {
                            matrix[boyRow, boyCol] = '.';
                        }
                        outMatrix = true;// извън полето е
                        Console.WriteLine("The delivery is late. Order is canceled.");
                        break;
                    }
                }
                else if (command == "right")
                {
                    if (boyCol < matrix.GetLength(1) - 1)
                    {
                        if (matrix[boyRow, boyCol + 1] == '*') { continue; }
                        if (matrix[boyRow, boyCol] != 'R')
                        {
                            matrix[boyRow, boyCol] = '.';
                        }
                        boyCol++;
                    }
                    else
                    {
                        if (matrix[boyRow, boyCol] == '-')
                        {
                            matrix[boyRow, boyCol] = '.';
                        }
                        outMatrix = true;
                        Console.WriteLine("The delivery is late. Order is canceled.");
                        break;
                    }
                }
                else if (command == "up")
                {
                    if (boyRow > 0)
                    {
                        if (matrix[boyRow - 1, boyCol] == '*') { continue; }
                        if (matrix[boyRow, boyCol] != 'R')
                        {
                            matrix[boyRow, boyCol] = '.';
                        }
                        boyRow--;
                    }
                    else
                    {
                        if (matrix[boyRow, boyCol] == '-')
                        {
                            matrix[boyRow, boyCol] = '.';
                        }
                        outMatrix = true;
                        Console.WriteLine("The delivery is late. Order is canceled.");
                        break;
                    }
                }
                else if (command == "down")
                {
                    if (boyRow < matrix.GetLength(0) - 1)
                    {
                        if (matrix[boyRow + 1, boyCol] == '*') { continue; }
                        if (matrix[boyRow, boyCol] != 'R')
                        {
                            matrix[boyRow, boyCol] = '.';
                        }
                        boyRow++;
                    }
                    else
                    {
                        if (matrix[boyRow, boyCol] == '-')
                        {
                            matrix[boyRow, boyCol] = '.';
                        }
                        outMatrix = true;
                        Console.WriteLine("The delivery is late. Order is canceled.");
                        break;
                    }

                }
                if (matrix[boyRow, boyCol] == 'P')// пицария
                {
                    Console.WriteLine($"Pizza is collected. 10 minutes for delivery.");
                    matrix[boyRow, boyCol] = 'R';
                    continue;
                }
                if (matrix[boyRow, boyCol] == 'A')//доставя пицата
                {
                    matrix[boyRow, boyCol] = 'P';// The position 'A' is marked as 'P'
                    Console.WriteLine("Pizza is delivered on time! Next order...");
                    break;
                }


            }
            if (outMatrix)
            {
                matrix[startRow, startCol] = ' ';
            }
            else { matrix[startRow, startCol] = 'B'; }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
