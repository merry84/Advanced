using System;
using System.Data;

namespace Armory
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //квадратна матрица
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = GetMatrix(size);
            int[] startPosition = GetCoords(matrix);

           

            ArmyOfficer officer = new ArmyOfficer(startPosition[0], startPosition[1]);//
            while (true)
            {
                if(officer.GoldCoins >= 65 ) {break; }// ако събере монетите

                officer.MoveInMatrix(size);//ако не е събрал достатъчно продължава да се движи

                if(officer.OutOfMatrix){break;}// ако излезне от матрицата

                char currentPosition = matrix[officer.IndexRow, officer.IndexCol];//текуща позиция на офицера
                if (currentPosition >= '0' && currentPosition <= '9')// ако има монети
                {
                    officer.GoldCoins += int.Parse(currentPosition.ToString());// ги добавяме
                    matrix[officer.IndexRow, officer.IndexCol] = '-';// и поставяме "-" на позицията
                }
                else if (currentPosition == 'M') //огледало на тази позиция
                {
                    //Ако армейският офицер се премести до огледало, той се телепортира до позицията на другото огледало и след това и двете огледала изчезват
                    MirrorMove(matrix, officer);
                }
            }
            if(officer.OutOfMatrix) Console.WriteLine("I do not need more swords!");
            else
            {
                Console.WriteLine("Very nice swords, I will come back for more!");
                matrix[officer.IndexRow, officer.IndexCol] = 'A';
            }
            Console.WriteLine($"The king paid {officer.GoldCoins} gold coins.");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static char[,] GetMatrix(int size)
        {
            char[,] matrix = new char[size,size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string newRow = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = newRow[col];

                }
            }
            return matrix;
        }

        private static void MirrorMove(char[,] matrix, ArmyOfficer officer)
        {
            matrix[officer.IndexRow, officer.IndexCol] = '-';
            for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (matrix[i, j] == 'M')
                {
                    officer.IndexRow = i;
                    officer.IndexCol = j;
                    matrix[i, j] = '-';
                    return;
                }
        }

       
        private static int[] GetCoords(char[,] matrix) //начална позиция 
        {
            int[] coords = new int[2];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'A')
                    {
                        coords[0] = i;
                        coords[1] = j;
                        matrix[i, j] = '-'; //Всички празни позиции ще бъдат маркирани с '-'.
                        return coords;
                    }
                }
            }

            return coords;
        }

    }
    
    class ArmyOfficer
    {
        public int IndexRow { get; set; }
        public int IndexCol { get; set; }

        public int GoldCoins { get; set; }
        public bool OutOfMatrix { get; set; }

        public ArmyOfficer(int indexRow, int indexCol)
        {
            IndexRow = indexRow;
            IndexCol = indexCol;
            GoldCoins = 0;
            OutOfMatrix = false;

        }

        public void MoveInMatrix(int size)
        {
            string command = Console.ReadLine();
            if (command == "up")
            {

                IndexRow++;
            }
            else if (command == "down")
            {

                IndexRow--;
            }
            else if (command == "left")

            {
                IndexCol--;
            }
            else if (command == "right")
            {
                IndexCol++;
            }

            if (IndexRow < 0 || IndexRow == size || IndexCol < 0 || IndexCol == size)
            {
                OutOfMatrix = true;
            }
        }
    }
}





