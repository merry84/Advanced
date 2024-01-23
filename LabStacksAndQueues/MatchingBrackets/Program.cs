namespace MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stackBrackets = new Stack<int>();
            for (int i = 0;i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stackBrackets.Push(i);
                }
                else if (input[i] == ')')
                {
                    int startIndex = stackBrackets.Pop();
                    Console.WriteLine(input.Substring(startIndex, i - startIndex +1));
                }
            }
        }
    }
}
