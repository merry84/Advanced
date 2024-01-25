namespace CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();
            SortedDictionary<char,int>text = new SortedDictionary<char,int>();

            for (int i = 0; i < letters.Length; i++)
            {
                if (!text.ContainsKey(letters[i]))
                {
                    text.Add(letters[i],1);
                    continue;
                }
                text[letters[i]]++;
            }

            foreach (var symbol in text)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
          
        }
    }
}
