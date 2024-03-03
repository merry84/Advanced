namespace BlindMan_sBuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            char[,] matrixGame = new char[sizes[0], sizes[1]];
            int rowPlay = -1;
            int colPlay = -1;

            for (int i = 0; i < matrixGame.GetLength(0); i++)
            {
                char[] newRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int j = 0; j < matrixGame.GetLength(1); j++)
                {
                    matrixGame[i, j] = newRow[j];
                    if (newRow[j] == 'B')
                    {
                        rowPlay = i;
                        colPlay = j;

                    }
                }
            }

            int nextRow = rowPlay;
            int nextCol = colPlay;

            int move = 0;
            int touched = 0;
            string command;
            while ((command = Console.ReadLine()) != "Finish")
            {
                if (command == "up")
                {
                    nextRow--;
                }
                else if (command == "down") { nextRow++; }
                else if (command == "left") { nextCol--; }
                else if (command == "right") { nextCol++; }

                if (!CanMoveInMatrix(nextRow, nextCol, matrixGame))// ако неможе да стъпи на позицията или ще бъде извън матрицата
                {//остава на същия ред и колона
                    nextRow = rowPlay;
                    nextCol = colPlay;
                    continue;
                }

                if (matrixGame[nextRow, nextCol] == 'P') // достигнал е противник
                {
                    matrixGame[nextRow, nextCol] = '-';
                    touched++;
                }

                move++;
                rowPlay = nextRow;
                colPlay = nextCol;

                if (touched == 3)//ако е докоснал трима опоненти
                {
                    break;
                }

            }

            Console.WriteLine("Game over!");
            Console.WriteLine($"Touched opponents: {touched} Moves made: {move}");

        }

        public static bool CanMoveInMatrix(int nextRow, int nextCol, char[,] matrixGame)
        {
            if (nextRow >= 0
                && nextRow < matrixGame.GetLength(0)
                && nextCol >= 0
                && nextCol < matrixGame.GetLength(1)
                && matrixGame[nextRow, nextCol] != 'O')
            {
                return true;
            }

            return false;
        }
    }
}
