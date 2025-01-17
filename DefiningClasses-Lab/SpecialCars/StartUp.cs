﻿using System.Xml;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine>engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            string command;
            while ((command = Console.ReadLine())!= "No more tires")
            {
                //{year} {pressure}
                string[] tiresArray = command.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

                int tYear1 = int.Parse(tiresArray[0]);
                double pressure1 = double.Parse(tiresArray[1]);
                int tYear2 = int.Parse(tiresArray[2]);
                double pressure2 = double.Parse(tiresArray[3]);
                int tYear3 = int.Parse(tiresArray[4]);
                double pressure3 = double.Parse(tiresArray[5]);
                int tYear4 = int.Parse(tiresArray[6]);
                double pressure4 = double.Parse(tiresArray[7]);

                var tire1 = new Tire(tYear1, pressure1);
                var tire2 = new Tire(tYear2,pressure2);
                var tire3 = new Tire(tYear3, pressure3);
                var tire4 = new Tire(tYear4, pressure4);
                tires.Add(new Tire[]{tire1,tire2,tire3,tire4});
            }

            while ((command = Console.ReadLine()) != "Engines done")
            {
                //{horsePower} {cubicCapacity} 
                string[] engineArray = command.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                int horsePower = int.Parse(engineArray[0]);
                double cubicCapacity = double.Parse(engineArray[1]);

                var engine = new Engine(horsePower, cubicCapacity);
                engines.Add(engine);
            }

            while ((command = Console.ReadLine()) != "Show special")
            {
                //{make} {model} {year} {fuelQuantity} {fuelConsumption} {engineIndex} {tiresIndex}
                string[] carArray = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string carMake = carArray[0];
                string carModel = carArray[1];
                int carYear = int.Parse(carArray[2]);
                double carQuantity = double.Parse(carArray[3]);
                double carConsumption = double.Parse(carArray[4]);
                int engineIndex = int.Parse(carArray[5]);
                int tiresIndex = int.Parse(carArray[6]);

                var newCar = new Car(carMake, carModel,carYear,carQuantity,carConsumption,engines[engineIndex],tires[tiresIndex]);
                cars.Add(newCar);
            }

            List<Car> specialCars = new List<Car>();
            foreach (Car car in cars)
            {
                //drive 20 kilometers all the cars, which were manufactured during 2017 or after, have horsepower above 330 and the sum of their tire pressure is between 9 and 10
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && (car.Tires.Sum(x => x.Pressure) >= 9 && car.Tires.Sum(x => x.Pressure) <= 10))
                {
                    car.Drive(20);
                    specialCars.Add(car);
                }
            }

            foreach (var car in specialCars)
            {
                Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}\nHorsePowers: {car.Engine.HorsePower}\nFuelQuantity: {car.FuelQuantity}");
            }

            /*"Make: {specialCar.Make}\n"
               "Model: {specialCar.Model}"
               "Year: {specialCar.Year}"
               "HorsePowers: {specialCar.Engine.HorsePower}"
               "FuelQuantity: {specialCar.FuelQuantity}"
               */
        }
    }
}
