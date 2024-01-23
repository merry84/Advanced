namespace SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string text = string.Empty;

            Stack<string> textStack = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "1")//appends someString to the end of the text
                {
                    textStack.Push(text);
                    text += command[1];
                }
                else if (command[0] == "2")//erases the last count elements from the text
                {
                    textStack.Push(text);
                    int countElement = int.Parse(command[1]);
                    text = text.Substring(0,text.Length - countElement);
                }
                else if (command[0] == "3")//- returns the element at position index from the text.
                {
                    int indexReturn = int.Parse(command[1]);
                    Console.WriteLine(text[indexReturn-1]);

                }
                else if (command[0] == "4")
                {
                    text = textStack.Pop();
                }

            }
        }
    }
}
