namespace SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vip = new HashSet<string>();//All VIP numbers start with a digit
            HashSet<string> regular = new HashSet<string>();



            while (true)
            {
                var input = Console.ReadLine();
                if (input == "PARTY")
                {
                    break;
                }

                foreach (var symbol in input)
                {
                    if (char.IsDigit(symbol))
                    {
                        vip.Add(input);
                    }
                    else
                    {
                        regular.Add(input);
                    }
                    break;
                }
            }

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "END") break;
                
                if (vip.Contains(command))
                {
                    vip.Remove(command);
                }

                if (regular.Contains(command))
                {
                    regular.Remove(command);
                }
            }

            int guestCount = vip.Count + regular.Count;
            Console.WriteLine(guestCount);
            foreach (var guest in vip)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in regular)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
