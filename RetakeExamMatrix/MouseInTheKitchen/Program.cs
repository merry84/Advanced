using System.ComponentModel.Design;
using System.Numerics;

int[] size = Console.ReadLine()
                .Split(",")
                .Select(x => int.Parse(x))
                .ToArray();
char[,] matrix = new char[size[0], size[1]];
int mouseRow = -1;
int mouseCol = -1;
int cheeseCount = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    char[] newRow = Console.ReadLine().ToCharArray();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = newRow[j];
        if (newRow[j] == 'M')
        {
            mouseRow = i;
            mouseCol = j;
            matrix[mouseRow, mouseCol] = '*';
        }
        if (matrix[i, j] == 'C') { cheeseCount++; }
    }
}
string command;
while ((command = Console.ReadLine()) != "danger")
{
    if (command == "left" && mouseCol == 0//ако излезне от полето
        || command == "right" && mouseCol == matrix.GetLength(1) - 1
        || command == "up" && mouseRow == 0
        || command == "down" && mouseRow == matrix.GetLength(0) - 1)
    {
        Console.WriteLine("No more cheese for tonight!");
        break;
    }
    else//скип 
    {

        if (command == "left" && matrix[mouseRow, mouseCol - 1] == '@') { continue; }
        else
        {
            if (command == "left") { mouseCol--; }

            if (command == "right" && matrix[mouseRow, mouseCol + 1] == '@') { continue; }
            else
            {
                if (command == "right") { mouseCol++; }
                if (command == "up" && matrix[mouseRow - 1, mouseCol] == '@') { continue; }
                else
                {
                    if (command == "up") { mouseRow--; }
                    if (command == "down" && matrix[mouseRow + 1, mouseCol] == '@') { continue; }
                    else
                    {
                        if (command == "down") { mouseRow++; }
                    }
                }

            }
        }

    }
    //•	If the mouse steps on C – position, it eats the cheese from the field, and the position is marked with "*".
    if (matrix[mouseRow, mouseCol] == 'C')//
    {
        cheeseCount--;
        matrix[mouseRow, mouseCol] = '*';
        if (cheeseCount == 0)
        {
            matrix[mouseRow, mouseCol] = 'M';
            Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
            break;
        }
        continue;
    }
    if (matrix[mouseRow, mouseCol] == 'T')// капан
    {
        Console.WriteLine("Mouse is trapped!");
        break;
    }

}
if (command == "danger")
{

    Console.WriteLine("Mouse will come back later!");
}
matrix[mouseRow, mouseCol] = 'M';
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}

