namespace FoodFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start by taking the first character of the vowels collection and the last character from the consonants collection.
            Queue<char> vowels = new Queue<char>(Console.ReadLine()//гласни
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse));
            Stack<char> consonants = new Stack<char>(Console.ReadLine()//съгласни
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .Select(char.Parse));
            HashSet<string> words = new HashSet<string>(new string[] { "pear", "flour", "pork", "olive" });
            HashSet<char> letters = new HashSet<char>();
            while (consonants.Any())
            {
                //if (!consonants.Any()) break;
                letters.Add(consonants.Pop());//A consonant letter is always removed from the collection, whether used or not.
                letters.Add(vowels.Peek());
                vowels.Enqueue(vowels.Dequeue());//A vowel letter is always returned to the collection, whether used or not.
            }
            List<string> wordsList = new List<string>();
            foreach (var item in words) //Then check if these letters are present in one or more of the given words.
               if (string.Join("", item.Intersect(letters)) == item) 
                 wordsList.Add(item); //If these letters are present, you should store the information. 

            Console.WriteLine($"Words found: {wordsList.Count} ");
            Console.WriteLine(string.Join(Environment.NewLine, wordsList));
        }
    }
}
