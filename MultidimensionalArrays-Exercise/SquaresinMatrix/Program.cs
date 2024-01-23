using System.Threading.Tasks.Sources;

namespace SquaresinMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            char[,] matrix = new char[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)//обхождаме матрицата
            {
                char[] text = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = text[col];
                }
            }
            int count = 0;

            for (int row = 0; row < matrix.GetLength(0)-1; row++)// -1 за да не излезнем от матрицата без последния ред
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)// без последната колона
                {
                    char currentSymbol = matrix[row,col];

                    if (currentSymbol == matrix[row + 1, col]
                        && currentSymbol == matrix[row, col + 1]
                        && currentSymbol == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
