namespace BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] parentheses = Console.ReadLine().ToCharArray();
            if (parentheses.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }
            Stack<char>stack = new Stack<char>();

            foreach (char itemParenthesis in parentheses)
            {
                if ("{[(".Contains(itemParenthesis))
                {
                    stack.Push(itemParenthesis);
                }
                else if (itemParenthesis == '}' && stack.Peek()== '{')
                {
                    stack.Pop();
                }
                else if (itemParenthesis == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else if (itemParenthesis == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
              
            }
            Console.WriteLine(stack.Any() ? "NO" : "YES");
        }
    }
}
