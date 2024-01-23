namespace DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());//row=col
            int[,] matrix = new int[size,size];

            for (int row = 0; row < matrix.GetLength(0); row++)//обхождаме матрицата
            {
                int[] number = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = number[col];
                }
            }

            int firstSumDiagonal = 0;
            int secondSumDiagonal = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)//size = matrix.GetLenght(0)
            {
               
                    firstSumDiagonal += matrix[row, row];
                    secondSumDiagonal += matrix[size- row - 1, row];
                
            }
            Console.WriteLine(Math.Abs(firstSumDiagonal- secondSumDiagonal));
        }
    }
}
