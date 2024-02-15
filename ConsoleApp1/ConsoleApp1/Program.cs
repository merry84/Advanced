//пълнене на матрица
int[] sizes = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string[,] matrix = new string[sizes[0], sizes[1]];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string[] newRow = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = newRow[col];
    }
}


//int size = int.Parse(Console.ReadLine());
//char[,] matrix = new char[size, size];

//for (int row = 0; row < matrix.GetLength(0); row++)
//{
//    string newRow = Console.ReadLine();
//    for (int col = 0; col < matrix.GetLength(1); col++)
//    {
//        matrix[row, col] = newRow[col];
//    }
//}
//рандъм позиция
//     private static int[] GetCoords(char[,] matrix)
//{
//    int[] coords = new int[2];
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//        for (int j = 0; j < matrix.GetLength(1); j++)
//        {
//            if (matrix[i, j] == 'A')
//            {
//                coords[0] = i;
//                coords[1] = j;
//                matrix[i, j] = '-';
//                return coords;
//            }
//        }
//    }
//    return coords;
//}



//печатане на матрица
static void PrintMatrix(string[,] matrix)
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
//проверка дали е в матрицата
static bool IsValidIndex(int size, int row, int col)
{
    return row >= 0 && row < size && col >= 0 && col < size;
}

//заместване на символи
//private static bool EatBoat(int row, int col, char[,] matrix)
//{
//    char currentSymbol = matrix[row, col];
//    if (currentSymbol == 'S' || currentSymbol == 'W' || currentSymbol == 'B')
//    {
//        matrix[row, col] = '-';
//        return true;
//    }
//    return false;
//}