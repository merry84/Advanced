namespace SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowArray = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowArray[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == symbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");

        }
        //public static int[,] ReadMatrix(int rows, int cols, string separator)
        //{
        //    int[,] matrix = new int[rows, cols];

        //    for (int row = 0; row < matrix.GetLength(0); row++)
        //    {
        //        int[] rowArray = Console.ReadLine().Split(separator).Select(int.Parse).ToArray();

        //        for (int col = 0; col < matrix.GetLength(1); col++)
        //        {
        //            matrix[row, col] = rowArray[col];
        //        }
        //    }

        //    return matrix;
        //}
    }
}
