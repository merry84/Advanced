using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;
using System;
using System.Runtime.InteropServices.ComTypes;

namespace StackAndQuele
{
    internal class StackQuele
    {
        static void Main(string[] args)
        {
            //You will be given an integer n for the size of the protected airspace (square-shaped matrix). On the next n lines, you will receive the rows of the airspace. 
            //The jetfighter will start at a random position, marked with the letter 'J'.In random positions also, enemy aircraft will be marked with the letter 'E'.
            //There will also be repair points marked with the letter 'R'.All of the empty positions will be marked with the symbol'-'.
            //HINT: It may be helpful to track the count of the enemy aircraft.
            //The jetfighter has an initial armor value of 300 units.When it receives a command, it moves one position towards the given direction. 
            //The program will end when аll enemy planes are shot down or the jetfighter’s armor becomes 0.The final state of the airspace, must always be printed on the console at the end.
            //On each turn, you will be guiding the jetfighter and giving it the direction, to move towards.The commands will be "up", "down", "left" and "right".
            //	If a position with '-'(dash) is reached, it means that the field is empty and the jetfighter awaits its next direction.
            //	If it encounters an enemy aircraft marked with 'E', a battle begins:
            //	The jetfighter shoots down the enemy plane(the position of the destroyed enemy plane will be marked with '-'(dash))
            //	In case this is the last enemy, the program ends and the following message should be displayed on the console: "Mission accomplished, you neutralized the aerial threat!"
            //o Do not forget the final state of the airspace.
            //	In case this is not the last enemy, the jetfighter takes damage – its armor loses 100 units.
            //o If its armor reaches zero, it crashes and the mission fails.The program ends and the following message should be displayed on the console: "Mission failed, your jetfighter was shot down! Last coordinates [{row}, {col}]!"
            //o Do not forget the final state of the airspace.
            //	If a position marked with 'R' is reached your plane is repaired and restores its armor to 300 units.
            //o The position must be marked with '-'(dash).
            //Input
            //•	On the first line, you are given the integer n – the size of the matrix(airspace).
            //•	The next n lines hold the values for every row.
            //•	On each of the next lines, you will get a direction command.
            //Output
            //•	If all enemy planes are shot down, print: 
            //o   "Mission accomplished, you neutralized the aerial threat!"
            //•	If your jetfighter is hit by an enemy plane three times, print: 
            //o   "Mission failed, your jetfighter was shot down! Last coordinates [{row}, {col}]!".
            //•	At the end, print the final state of the matrix(airspace) with the last known position of your jetfighter on it.
            //Constraints
            //•	The size of the square matrix(airspace) will be between[4…10].
            //•	The jetfighter starting position will always be marked with 'J'.
            //•	There will be always a random count(1…5) fields marked with 'R'(repair).
            //•	The commands given will direct the jetfighter only within the limits of the matrix(airspace).
            //•	There will be always two output scenarios - either the enemy shoots down your plane or your plane shoots down all the enemy planes.
            //•	You will always receive enough commands to end the battle.
            int size = int.Parse(Console.ReadLine());
            string[,] matrix = new string[size, size];


            int submRow = -1;
            int submCol = -1;


            int countEnemy = 0;
            int health = 300;

            for (int i = 0; i < matrix.GetLength(0); i++)// рандъм позиция и послe "-"
            {
                string newRow = Console.ReadLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = newRow[j].ToString();
                    if (newRow[j] == 'J')
                    {

                        submRow = i;
                        submCol = j;
                        matrix[i, j] = "-";

                    }
                    else if (newRow[j] == 'E')
                    {
                        countEnemy++;

                    }
                }
            }

            while (countEnemy > 0)
            {
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

                string position = matrix[submRow, submCol];
                matrix[submRow, submCol] = "-";
                if (position == "E")
                {
                    countEnemy--;
                    health -= 100;
                }
                if (health == 0)
                {
                    Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{submRow}, {submCol}]!");
                    matrix[submRow, submCol] = "J";

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write(matrix[i, j]);
                        }
                        Console.WriteLine();

                    }
                    return;
                }
                if (position == "R")
                {
                    health = 300;
                }
            }

            Console.WriteLine($"Mission accomplished, you neutralized the aerial threat!");
            matrix[submRow, submCol] = "J";

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
