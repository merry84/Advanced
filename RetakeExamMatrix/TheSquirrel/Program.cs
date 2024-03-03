namespace TheSquirrel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(", ");
            char[,] matrix = new char[size, size];
            int sRow = -1;
            int sCol = -1;
            int count = 0;
            bool isTrapped = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] newRow = Console.ReadLine().ToCharArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = newRow[j];
                    if (newRow[j] == 's')
                    {
                        sRow = i;
                        sCol = j;
                        
                    }
                }
            }

            foreach (var way in commands) //– "left", "right", "down", and "up"
            {
                int nextRow = sRow;
                int nextCol = sCol;
                if (way == "left")
                {
                    nextCol--;
                }

                if (way == "right")
                {
                    nextCol++;
                }

                if (way == "up")
                {
                    nextRow--;
                }

                if (way == "down")
                {
                    nextRow++;
                }

                if (nextRow >= matrix.GetLength(0) // извън полето е
                    || nextCol >= matrix.GetLength(1)
                    || nextRow < 0 || nextCol < 0)
                {
                    isTrapped = true;
                    Console.WriteLine("The squirrel is out of the field.");
                    break;
                }

                sRow = nextRow;
                sCol = nextCol;
                char letter = matrix[sRow, sCol];

                if (letter == 't')
                {
                    isTrapped = true;
                    Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                    break;
                }
                if (letter == 'h')
                {
                    matrix[sRow, sCol] = '*';
                    count++;
                    if (count == 3)
                    {
                        Console.WriteLine("Good job! You have collected all hazelnuts!");
                        break;
                        //Console.WriteLine("There are more hazelnuts to collect.");
                    }
                }
            }

            if (!isTrapped && count < 3)
            {
                Console.WriteLine("There are more hazelnuts to collect.");
            }

            Console.WriteLine($"Hazelnuts collected: {count}");
           
        }
       

    }
}
/*
4
down, down, right, right
h***
***h
*s*t
**h*
* */