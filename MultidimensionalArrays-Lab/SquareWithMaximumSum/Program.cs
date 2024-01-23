namespace SquareWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = ReadMatrix(input[0], input[1], ", ");
            int maxSquareSum = 0;
            int maxRowsSum = 0;
            int maxColsSum = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)//няма да излезнем извън матрицата -1
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)//няма да излезнем извън матрицата -1
                {
                    int squareSum = matrix[row, col]
                                    + matrix[row, col + 1]
                                    + matrix[row + 1, col]
                                    + matrix[row + 1, col + 1];

                    if (squareSum > maxSquareSum)
                    {
                        maxRowsSum = row;
                        maxColsSum = col;
                        maxSquareSum = squareSum;
                    }
                }
            }
            Console.WriteLine($"{matrix[maxRowsSum, maxColsSum]} {matrix[maxRowsSum,maxColsSum+1]}");// първия ред с двете числа
            Console.WriteLine($"{matrix[maxRowsSum + 1, maxColsSum]} {matrix[maxRowsSum +1,maxColsSum+1]}");//вторият ред с двете числа
            Console.WriteLine(maxSquareSum);

        }
        public static int[,] ReadMatrix(int rows, int cols, string separator)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowArray = Console.ReadLine().Split(separator).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowArray[col];
                }
            }

            return matrix;
        }
    }
}
