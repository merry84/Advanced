namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] pascal = new long[n][];

            for (int row = 0; row < n; row++)
            {
                pascal[row] = new long[row + 1];
                for (int col = 0; col < pascal[row].Length; col++)
                {
                    if (row == 0)
                    {
                        pascal[row][col] = 1;
                        continue;
                    }

                    if (col < pascal[row - 1].Length)
                    {
                        pascal[row][col] += pascal[row - 1][col];
                    }

                    if (col > 0)
                    {
                        pascal[row][col] += pascal[row - 1][col - 1];
                    }
                }
            }
            foreach (long[] row in pascal)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
