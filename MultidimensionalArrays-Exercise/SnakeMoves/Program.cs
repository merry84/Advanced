namespace SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rows = input[0];
            int cols = input[1];
            char[,] matrix = new char[rows, cols];
            string text = Console.ReadLine();
            int textIndex = 0;//индекси на символите в текста

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                //при четен ред 0->последен индекс
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = text[textIndex];
                        textIndex++;
                        if (textIndex >= text.Length)
                        {
                            textIndex = 0;
                        }
                    }
                }
                     // при нечетен от поледен до 0 индекс
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = text[textIndex];
                        textIndex++;
                        if (textIndex >= text.Length)
                        {
                            textIndex = 0;
                        }
                    }
                }
            }
            PrintMatrix(matrix);
        }
        static void PrintMatrix(char[,] matrix)
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
