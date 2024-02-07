using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    class Car
    {
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make,model,year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make
        { get { return make; } set { make = value; } }

        public string Model
        { get { return model; } set { model = value; } }

        public int Year
        { get { return year; } set { year = value; } }

        public double FuelQuantity
        { get { return fuelQuantity; } set { fuelQuantity = value; } }

        public double FuelConsumption
        { get { return fuelConsumption; } set { fuelConsumption = value; } }

        public void Drive(double distance)
        {
            if (distance * fuelConsumption > fuelQuantity)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                fuelQuantity -= distance * fuelConsumption;
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\r\n " +
                   $"Model: {this.Model}\r\n " +
                   $"Year: {this.Year}\r\n " +
                   $"Fuel: {this.FuelQuantity:F2}";
        }

    }
}