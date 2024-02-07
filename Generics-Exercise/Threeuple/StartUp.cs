namespace Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //•	The first one is holding a name, an address and a town. Format of the input:
            // {first name} {last name} {address} {town}
            // •	The second line is holding a name, beer liters, and a boolean variable with value - drunk or not. Format:
            // {name} {liters of beer} {drunk or not}
            // •	The last line will hold a name, a bank balance (double) and a bank name. Format:
            // {name} {account balance} {bank name}
            string[] firstLine = Console.ReadLine().Split();
            var names = $"{firstLine[0]} {firstLine[1]}";
            string adres = firstLine[2] ;
            string town = firstLine[3] ;
            var infoThreeuple =new  Threeuple<string,string,string> (names,adres,town) ;

            string[] secondLine = Console.ReadLine()
                .Split();
            string nameBeer = secondLine[0] ;
            int leterOfBeer = int.Parse(secondLine[1]);
            var drunkOrNot = IsDrunk(secondLine[2]) ;
            var beerInfo = new Threeuple<string, int, bool>(nameBeer, leterOfBeer, drunkOrNot);

            string[] lastLine = Console.ReadLine()
                .Split();
            string nameOfPeople = lastLine[0] ;
            double accountBalance = double.Parse(lastLine[1]);
            string bankName = lastLine[2] ;
            var bankInfo = new Threeuple<string, double, string>(nameOfPeople, accountBalance, bankName);

            Console.WriteLine(infoThreeuple);
            Console.WriteLine(beerInfo);
            Console.WriteLine(bankInfo);


        }

        public static bool IsDrunk(string input)
        {
            if (input == "drunk")
            {
                return true ;
            }
            return false;
        }
    }
}
