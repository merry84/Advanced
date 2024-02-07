namespace GenericCountMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                box.Add(input);
            }

            string itemCompare = Console.ReadLine();
            Console.WriteLine(box.GetCount(itemCompare));
        }
    }
}
