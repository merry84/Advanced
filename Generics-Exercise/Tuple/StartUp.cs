namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] info = Console.ReadLine()
                .Split();
            //{first name} {last name} {address}
            var name = $"{info[0]} {info[1]}";
            var adres = info[2];
            Tuple<string, string> infoTuple = new Tuple<string, string>(name, adres);

            string[] amountOfBeer = Console.ReadLine()
                .Split();
            //{name} {liters of beer}
            var nameBeer = amountOfBeer[0];
            var litersOfBeer = int.Parse(amountOfBeer[1]);
            Tuple<string, int> beerInfo = new Tuple<string, int>(nameBeer, litersOfBeer);

            string[] lastLIne = Console.ReadLine()
                .Split();
            //{integer} {double}
            int first = int.Parse(lastLIne[0]);
            double second = double.Parse(lastLIne[1]);
            Tuple<int, double> lineTuple = new Tuple<int, double>(first, second);

            Console.WriteLine(infoTuple);
            Console.WriteLine(beerInfo);
            Console.WriteLine(lineTuple);


        }
    }
}
