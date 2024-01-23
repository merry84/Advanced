using System.Runtime.InteropServices.ComTypes;

namespace JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //назъбена матрица
            int rows = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rows][];

            //пълним матрицата
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row] = Console.ReadLine()// поплучаваме броя колони от конзолата
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
            // анализ на матрицата
            // провека дали има редове с еднаква дължина
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)// -1 ->без последния ред9под него няма друг
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    matrix[row] = matrix[row].Select(element => element * 2).ToArray();//умножаваме всеки елемет от реда *2
                    matrix[row + 1] = matrix[row + 1].Select(element => element * 2).ToArray();
                }
                else
                {
                    matrix[row] = matrix[row].Select(element => element / 2).ToArray();//разделяме на 2 всеки елемент от реда
                    matrix[row + 1] = matrix[row + 1].Select(element => element / 2).ToArray();
                }
            }
            //команди
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArg = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int row = int.Parse(commandArg[1]);
                int col = int.Parse(commandArg[2]);
                int value = int.Parse(commandArg[3]);
                if (commandArg[0] == "Add")
                {
                    if (row >= 0 && row < matrix.GetLength(0)
                                 && col >= 0
                                 && col < matrix[row].Length)//дължината на реда за да намерим колко са колоните
                    {
                        matrix[row][col] += value;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commandArg[0] == "Subtract")
                {
                    if (row >= 0 && row < matrix.GetLength(0)
                                 && col >= 0
                                 && col < matrix[row].Length)//дължината на реда за да намерим колко са колоните
                    {
                        matrix[row][col] -= value;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
