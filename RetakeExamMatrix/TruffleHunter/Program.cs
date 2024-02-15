using System;

namespace TruffleHunter
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //квадратна матрица
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                char[] newRow = Console.ReadLine().Replace(" ", string.Empty).ToCharArray();//заместваме интевалите с нищо
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = newRow[col];
                }
            }
            //•	Black truffle - 'B'
            // •	Summer truffle - 'S'
            // •	White truffle - 'W'
            int blackTruffle = 0;
            int summerTruffle = 0;
            int whiteTruffle = 0;
            int countEatTruffle = 0;
            string command;
            while ((command = Console.ReadLine()) != "Stop the hunt")
            {
                //•	"Collect {row} {col}" 
                //•	"Wild_Boar {row} {col} {direction}"
                string commandName = command.Split()[0];
                int row = int.Parse(command.Split()[1]);
                int col = int.Parse(command.Split()[2]);

                if (commandName == "Collect")
                {
                    if (IsValidIndex(size, row, col))
                    {
                        char truffle = matrix[row, col];// B,S,W
                        matrix[row, col] = '-';
                        if (truffle == 'B')
                        {
                            blackTruffle++;
                        }
                        else if (truffle == 'S')
                        {
                            summerTruffle++;
                        }
                        else if (truffle == 'W')
                        {
                            whiteTruffle++;
                        }
                    }
                }
                else if (commandName == "Wild_Boar")
                {
                    string direction = command.Split()[3];//"up", "down", "left" and "right".

                    if (direction == "up")//прескача ред или колона като се движи
                    {
                        while (IsValidIndex(size, row, col))
                        {
                            if (EatBoat(row, col, matrix))
                            {
                                countEatTruffle++;
                            }
                            row -= 2;// два реда нагоре
                        }
                    }
                    else if (direction == "down")
                    {
                        while (IsValidIndex(size, row, col))
                        {
                            if (EatBoat(row, col, matrix))
                            {
                                countEatTruffle++;
                            }
                            row += 2;// два реда нагоре
                        }
                    }
                    else if (direction == "left")
                    {
                        while (IsValidIndex(size, row, col))
                        {
                            if (EatBoat(row, col, matrix))
                            {
                                countEatTruffle++;
                            }
                            col -= 2;
                            
                        }
                    }
                    else if (direction == "right")
                    {
                        while (IsValidIndex(size, row, col))
                        {
                            if (EatBoat(row, col, matrix))
                            {
                                countEatTruffle++;
                            }
                            col += 2;// два реда нагоре
                        }
                    }
                }
            }

            Console.WriteLine($"Peter manages to harvest {blackTruffle} black, {summerTruffle} summer, and {whiteTruffle} white truffles.");
            Console.WriteLine($"The wild boar has eaten {countEatTruffle} truffles.");
            PrintMatrix(matrix);
        }

        private static bool EatBoat(int row, int col, char[,] matrix)
        {
            char currentSymbol = matrix[row, col];
            if (currentSymbol == 'S' || currentSymbol == 'W' || currentSymbol == 'B')
            {
                matrix[row, col] = '-';
                return true;
            }
            return false;
        }

        static bool IsValidIndex(int size, int row, int col)
        {
            return row >= 0 && row < size && col >= 0 && col < size;
        }
        static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
