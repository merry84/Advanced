namespace FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int capasityOfRack = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(clothes);

            int allRackUsed = 1;
            int rackCapacity = 0;

            while (stack.Count > 0)
            {
                if (stack.Peek() + rackCapacity <= capasityOfRack)
                {
                    rackCapacity += stack.Pop();
                }
                else
                {
                    rackCapacity = stack.Pop();
                    allRackUsed++;
                }
            }
            Console.WriteLine(allRackUsed);
        }
    }
}
