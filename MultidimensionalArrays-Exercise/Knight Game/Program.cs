using System.Runtime.Serialization.Json;

namespace Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            /*       ходове на коня
                 1 -> 2 нагоре 1 надясно+
                 2 -> 2 нагоре 1 наляво+
                 3 -> 2 надолу и 1 надясно+
                 4 -> 2 надолу и 1 наляво+
                 5 -> 1 нагоре и 2 надясно+
                 6 -> 1 нагоре и 2 наляво+
                 7 -> 1 надолу и 2 надясно
                 8 -> 1 надолу и 2 наляво
            */
            // квадратна матрица
            int size = int.Parse(Console.ReadLine());
            if (size < 3)
            {
                Console.WriteLine(0);
                return;
            }
            char[,]matrix = new char[size,size];

            //пълним матрицата
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] letter = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = letter[col];
                }
            }

            int removeKnight = 0;

            while (true)
            {
                int maxAttack = 0;
                int maxRowAttack = 0;
                int maxColAttack = 0;

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        int currentSymbol = matrix[row,col];

                        if (currentSymbol == 'K')
                        {//колко коня атакуване (натъпване при преместване)
                            int attackedKnight = AttackKnight(row, col, size, matrix);

                            if (attackedKnight > maxAttack)//дали е най-атакуващия
                            {//коня с най-много атаки
                                maxAttack = attackedKnight;
                                maxRowAttack = row;
                                maxColAttack = col;
                            }
                        }   
                    }
                }

                if (maxAttack == 0)
                {
                    break;//нямам коне, които да атакуват
                }
                else
                { //имам кон за премахване
                    matrix[maxRowAttack, maxColAttack] = '0';
                    removeKnight++;
                }
            }
            Console.WriteLine(removeKnight);
        }

        static int AttackKnight(int row, int col, int size, char[,] matrix)
        {
            int count = 0;// брояч на атакуваните коне
            //ходове на коня

            if (IsValidIndex(size, row - 2, col + 1))// 1 -> 2 нагоре 1 надясно
            {
                if (matrix[row - 2, col + 1] == 'K')//ако има кон
                {
                    count++;//добяваме към брояча стъпването 
                }
            }

            if (IsValidIndex(size, row - 2, col - 1))//2 нагоре 1 наляво
            {
                if (matrix[row - 2, col - 1] == 'K')
                {
                    count++;
                }
            }

            if (IsValidIndex(size, row + 2, col + 1))//2 надолу и 1 надясно
            {
                if (matrix[row + 2, col + 1] == 'K')
                {
                    count++;
                }
            }

            if (IsValidIndex(size, row + 2, col - 1))// 2 надолу и 1 наляво
            {
                if (matrix[row + 2, col - 1] == 'K')
                {
                    count++;
                }
            }

            if (IsValidIndex(size, row - 1, col + 2))
            {
                if (matrix[row - 1, col + 2] == 'K')//1 нагоре и 2 надясно
                {
                    count++;
                }
            }

            if (IsValidIndex(size, row - 1, col - 2))//1 нагоре и 2 наляво
            {
                if (matrix[row - 1, col - 2] == 'K')
                {
                    count++;
                }
            }

            if (IsValidIndex(size, row + 1, col + 2))//1 надолу и 2 надясно
            {
                if (matrix[row + 1, col + 2] == 'K')
                {
                    count++;
                }
            }

            if (IsValidIndex(size, row + 1, col - 2))//1 надолу и 2 наляво
                                                     
            {
                if (matrix[row + 1, col - 2] == 'K')
                {
                    count++;
                }
            }

            return count;

        }
        static bool IsValidIndex(int size, int row, int col)
        {
            return row >= 0 && row < size && col >= 0 && col < size;
        }
    }
}
