using System.Numerics;


namespace BirthdayCelebration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Serving is done exactly one plate at a time. You must start picking from the last stacked plate and start serving from the first entered guest. 
            //guests' capacity, 
            //plates of food
            Queue<int> guests = new Queue<int>(Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Stack<int> plates = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            int wastedGramsOfFood = 0;
            while (guests.Any() && plates.Any())
            {
                int guest = guests.Peek();
                int plate = plates.Peek();

                int reduceResult = guest - plate;
                if (reduceResult <= 0)
                {
                     wastedGramsOfFood+= reduceResult;
                    guests.Dequeue();
                    plates.Pop();
                }
                else//reduceResult > 0
                {
                    guests.Dequeue();
                    plates.Pop();
                    //Ако сте успели да напълните всички гости, отпечатайте останалите готови чинии с храна, от последната въведена – до първата,
                    //в противен случай трябва да отпечатате останалите гости, по ред на влизане – от първата въведена – до последната .
                    guests = new Queue<int>(guests.Reverse());
                    guests.Enqueue(reduceResult);
                    guests = new Queue<int>(guests.Reverse());
                }

            }

            if (guests.Any())
            {
                Console.WriteLine($"Plates: {string.Join(" ",guests)}");
            }

            if (plates.Any())
            {
                Console.WriteLine($"Guests: {string.Join(" ",plates)}");
            }
            Console.WriteLine($"Wasted grams of food: {Math.Abs(wastedGramsOfFood)}");
            // Stack<int> guests = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray().Reverse());
            // Stack<int> food = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            //       int wastedFoodCounter = 0;
            //            while (true)
            //            {
            //                if (!guests.Any() || !food.Any()) break;
            //                int currGuest = guests.Pop();
            //                int currFood = food.Pop();
            //                currGuest -= currFood;
            //                if (currGuest <= 0) wastedFoodCounter -= currGuest;
            //                else guests.Push(currGuest);
            //            }
            //            if (food.Any()) Console.WriteLine($"Plates: {string.Join(" ", food)}");
            //            else Console.WriteLine($"Guests: {string.Join(" ", guests)}");
            //            Console.WriteLine($"Wasted grams of food: {wastedFoodCounter}");
        }
    }
}
