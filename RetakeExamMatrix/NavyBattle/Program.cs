namespace NavyBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());
            string[,] matrix = new string [size, size];


            int submRow = -1;
            int submCol = -1;

            int cruisersHit = 0;
            int minesHit = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)// рандъм позиция и посли "-"
            {
                string newRow = Console.ReadLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = newRow[j].ToString();
                    if (newRow[j] == 'S')
                    {
                        matrix[i, j] = "-";
                        submRow = i;
                        submCol = j;
                       
                    }
                }
            }

            while (true)
            {
                if (minesHit == 3)// 3 мини
                {
                    Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{submRow}, {submCol}]!");
                    break;
                }

                if (cruisersHit == 3) // всички са унищожени
                {
                    Console.WriteLine($"Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                    break;
                }
                string command = Console.ReadLine().ToLower();
                if (command == "left")
                {
                    submCol--;
                }

                if (command == "right")
                {
                    submCol++;
                }

                if (command == "up")
                {
                    submRow--;
                }

                if (command == "down")
                {
                    submRow++;
                }

                if (matrix[submRow, submCol] == "C")
                {
                    matrix[submRow, submCol] = "-";
                    cruisersHit++;
                }

                if (matrix[submRow, submCol] == "*")
                {
                    matrix[submRow, submCol] = "-";
                    minesHit++;
                }
            }

            matrix[submRow, submCol] = "S";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
