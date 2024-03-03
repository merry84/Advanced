using System.Drawing;

namespace Matrix
{
    internal class ChickenSnack
    {
        static void Main(string[] args)
        {
            Stack<int> amountOfMoney =
                new Stack<int>(Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse));
            Queue<int> priceSize = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int countFoodHenry = 0;
            while (amountOfMoney.Any() && priceSize.Any())
            {
                int money = amountOfMoney.Peek();
                int food = priceSize.Peek();

                if (money == food)
                {

                    amountOfMoney.Pop();
                    priceSize.Dequeue();
                    countFoodHenry++;
                }

                else if (money > food)
                {

                    amountOfMoney.Pop();
                    priceSize.Dequeue();

                    if(amountOfMoney.Any())
                    {
                        int takeChange = money - food;
                        
                        amountOfMoney.Push(takeChange + amountOfMoney.Pop());

                    }
                    else
                    {
                        amountOfMoney.Push(money - food);

                    }
                    countFoodHenry++;

                }

                else
                {
                    amountOfMoney.Pop();
                    priceSize.Dequeue();
                }
            }
            if (countFoodHenry >= 4)
            {
                Console.WriteLine($"Gluttony of the day! Henry ate {countFoodHenry} foods.");
            }

            else if (countFoodHenry > 0)
            {
                if (countFoodHenry == 1)
                {
                    Console.WriteLine($"Henry ate: {countFoodHenry} food.");
                }
                else
                {
                    Console.WriteLine($"Henry ate: {countFoodHenry} foods.");

                }
            }

            else
            {
                Console.WriteLine("Henry remained hungry. He will try next weekend again.");
            }
        }
    }
}
