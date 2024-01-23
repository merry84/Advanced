namespace MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[size[0], size[1]];

            for (int row= 0; row < matrix.GetLength(0); row++)
            {
                int[]numbers = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = numbers[col];
                }
            }

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < matrix.GetLength(0)-2; row++)// -2 за да не излезнем от матрицата
            {
                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {
                    int currentSum = 0;
                    for (int i = 0; i < 3; i++)//square 3 x 3
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            currentSum += matrix[row + i,col + j];
                        }   
                    }

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxCol = col;
                        maxRow = row;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            //•	Print the elements of the 3 x 3 square as a matrix
            for (int i = maxRow; i < maxRow + 3; i++)
            {
                for (int j = maxCol; j < maxCol + 3; j++)
                {
                    Console.Write(matrix[i,j]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
