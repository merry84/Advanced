namespace SpeedRacing
{
    public class StartUp
    {
        static void Main()
        {
            int countCar = int.Parse(Console.ReadLine());
            List<Car>cars = new List<Car>();
            for (int i = 0; i < countCar; i++)
            {
                string[] carArgulents = Console.ReadLine().Split();
                string model = carArgulents[0];
                double fuel =double.Parse(carArgulents[1]);
                double fuelConsumption = double.Parse(carArgulents[2]);
                Car car = new Car(model, fuel, fuelConsumption, 0);
                cars.Add(car);
            }

            string command;
            while ((command = Console.ReadLine())!= "End")//"Drive {carModel} {amountOfKm}"
            {
                string[] action = command.Split();
                string model = action[1];
                double km = double.Parse(action[2]);
                Car car = cars
                    .Where(c => c.Model == model)
                    .FirstOrDefault();
                car.Drive(km);
            }
            // "{model} {fuelAmount} {distanceTraveled}"
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
