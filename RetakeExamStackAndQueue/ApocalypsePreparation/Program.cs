using System.Runtime.InteropServices.ComTypes;

namespace ApocalypsePreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You should start by getting the first value of textile and the last value of medicaments and
            // if their sum is equal to any of the items in the table below create that item and remove both values. Otherwise,
            // check if the sum is bigger than the value of the MedKit, create the MedKit, remove both values, and add the
            // remaining resources(of the sum) to the next value in the medicament collection (Take the element from the
            // collection, add the remaining sum to it, and put the element back to its place). If you can’t create anything, remove
            // the textile value, add 10 to the medicament value, and return the medicament back to its place, into its collection.
            // You need to stop creating healing items when either the textile or the medicaments are exhausted.
            // Healing item Resources needed
            // Patch 30
            // Bandage 40
            // MedKit 100
            // In the end, you should print on the console message for the sequence that has ended, then the created items, and in
            // the end the remaining items (if any).
            // Input
            //  On the first line, you will receive a sequence of integers representing the textiles, separated by a single
            // space (" ").
            //  On the second line, you will receive a sequence of integers representing the medicaments, separated by a
            // single space (" ").
            // Output
            //  On the first line print which one of the collections is over:
            // o If the textile is over print: "Textiles are empty."
            // o If the medicaments are over print: "Medicaments are empty."
            // o If both are empty print: "Textiles and medicaments are both empty."

            //  On the next n lines print only the created items (if any) ordered by the amount created descending, then
            // by name alphabetically:
            // "{item name} - {amount created}
            //  {item name} - {amount created}

            // Hint: Do not print items, which are not created.
            //  On the last line print the remaining items(if any):
            // o If there are any medicaments left:
            // "Medicaments left: {medicament1}, {medicament2}…"
            // o If there are any textiles left:
            // "Textiles left: {textile1}, {textile
            Queue<int> textiles = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Stack<int> medicaments = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Dictionary<string, int> itemDictionary = new Dictionary<string, int>();

            while (textiles.Any() && medicaments.Any())
            {
                int sum = medicaments.Peek() + textiles.Peek();
                if (sum == 30)
                {
                    if (!itemDictionary.ContainsKey("Patch"))
                    {
                        itemDictionary.Add("Patch", 0);
                    }

                    itemDictionary["Patch"]++;
                    textiles.Dequeue();
                    medicaments.Pop();
                }
                else if (sum == 40)
                {
                    if (!itemDictionary.ContainsKey("Bandage"))
                    {
                        itemDictionary.Add("Bandage", 0);
                    }

                    itemDictionary["Bandage"]++;
                    textiles.Dequeue();
                    medicaments.Pop();
                }
                else if (sum == 100)
                {
                    if (!itemDictionary.ContainsKey("MedKit"))
                    {
                        itemDictionary.Add("MedKit", 0);
                    }
                    itemDictionary["MedKit"]++;
                    textiles.Dequeue();
                    medicaments.Pop();
                }
                else if (sum > 100)
                {
                    if (!itemDictionary.ContainsKey("MedKit"))
                    {
                        itemDictionary.Add("MedKit", 0);
                    }

                    itemDictionary["MedKit"]++;
                    textiles.Dequeue();
                    medicaments.Pop();

                    //remaining resources(of the sum) to the next value in the medicament collection (Take the element from the
                    // // collection, add the remaining sum to it, and put the element back to its place). If you can’t create anything, remove
                    // // the textile value, add 10 to the medicament value, and return the medicament back to its place, into its collection.
                    int sumToAdd = sum - 100;
                    int itemToAdd = medicaments.Peek();
                    itemToAdd += sumToAdd;
                    medicaments.Pop();
                    medicaments.Push(itemToAdd);


                }
                else//If you can’t create anything, remove
                    // the textile value, add 10 to the medicament value, and return the medicament back to its place, into its collection
                {
                    textiles.Dequeue();
                    int currMedicament = medicaments.Peek();
                    currMedicament += 10;
                    medicaments.Pop();
                    medicaments.Push(currMedicament);

                }
            }
                 //all empty
            if (textiles.Count == 0 && textiles.Count == 0)
            {
                Console.WriteLine("Textiles and medicaments are both empty.");
            }

            if (medicaments.Count == 0 && medicaments.Count != 0)
            {
                Console.WriteLine("Medicaments are empty.");
            }
            // If the textile is over print: "Textiles are empty."
            if (textiles.Count == 0 && textiles.Count != 0)
            {
                Console.WriteLine("Textiles are empty.");
            }

            if (itemDictionary.Any())
            {
                foreach (var item in itemDictionary.OrderByDescending(c=>c.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }

            if (medicaments.Any())
            {
                Console.WriteLine($"Medicaments left: {string.Join(", ",medicaments)}");
            }

            if (textiles.Any())
            {
                Console.WriteLine($"Textiles left: {string.Join(", ",textiles)}");
            }
        }
    }
}
