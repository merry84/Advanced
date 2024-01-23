namespace ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            HashSet<string>parking = new HashSet<string>();

            while ((input =Console.ReadLine())!= "END")
            {
                string[] command = input.Split(", ");
                string direction = command[0];
                string carNumber = command[1];
                if (direction == "IN")
                {
                    parking.Add(carNumber);
                }

                if (direction == "OUT")
                {
                    parking.Remove(carNumber);
                }
            }//ако няма коли в паркинга изпиши че е празен или/:/ изпиши номерата на колите
            Console.WriteLine(parking.Count == 0 ? "Parking Lot is Empty" : $"{string.Join("\n",parking)}");
        }
    }
}
