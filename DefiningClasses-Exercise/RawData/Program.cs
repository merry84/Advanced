namespace RawData
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car>cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                //"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"
                string[] inputInfo = Console.ReadLine().Split();
                string model = inputInfo[0];
                int speed = int.Parse(inputInfo[1]);
                int power = int.Parse(inputInfo[2]);
                int weight = int.Parse(inputInfo[3]);
                string type = inputInfo[4];
                double tire1Pressure = double.Parse(inputInfo[5]);
                int tire1Age = int.Parse(inputInfo[6]);
                double tire2Pressure = double.Parse(inputInfo[7]);
                int tire2Age = int.Parse(inputInfo[8]);
                double tire3Pressure = double.Parse(inputInfo[9]);
                int tire3Age = int.Parse(inputInfo[10]);
                double tire4Pressure = double.Parse(inputInfo[11]);
                int tire4Age = int.Parse(inputInfo[12]);
                Engine engine = new Engine(speed, power);
                Cargo cargo = new Cargo(type, weight);
                Tire[] tires = new Tire[]
                {
                    new Tire(tire1Pressure, tire1Age),
                    new Tire(tire2Pressure, tire2Age),
                    new Tire(tire3Pressure, tire3Age),
                    new Tire(tire4Pressure, tire4Age),
                };
                Car car = new Car(model, engine, cargo, tires);

                cars.Add(car);
            }

            string command = Console.ReadLine();
            //"fragile" or "flammable".
            if (command == "fragile")//print all cars, whose cargo is "fragile" and have a pressure of a single tire < 1.
            {
               cars = cars.Where(c => c.Tires.Any(t => t.Pressure < 1)).ToList();
            }
            else if (command == "flammable")//print all cars, whose cargo is "flammable" and have engine power > 250
            {
                cars = cars.Where(c => c.Engine.Power > 250).ToList();

            }

            foreach (var c in cars)
            {
                Console.WriteLine(c.Model);
            }
        }
    }
}
