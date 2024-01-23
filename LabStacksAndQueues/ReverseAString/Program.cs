namespace ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char>chars = new Stack<char>();
            foreach (char c in input)
            {
                chars.Push(c);
            }
            while (chars.Count > 0)
            {
                Console.Write(chars.Pop());
            };
            Console.WriteLine();
        }
    }
}
