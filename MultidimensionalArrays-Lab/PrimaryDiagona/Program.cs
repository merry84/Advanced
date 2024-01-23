namespace PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = row;

            int[,] matrix = ReadMatrix(row, col, " ");
            int sumDiagonal = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sumDiagonal += matrix[i, i];
            }
            Console.WriteLine(sumDiagonal);
            // намиране на сумата на елементите по обратен диагонал
            // for (int i = 0; i < matrix.GetLength(0); i++)
            // {
            //      sum += matrix[i, matrix.GetLength(1) - i - 1];
            // }

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
