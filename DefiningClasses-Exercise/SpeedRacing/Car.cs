using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    { 
        private string model;
        private	double fuelAmount;
        private	double fuelConsumptionPerKilometer;
        private	double travelledDistance;
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer, double travelledDistance)
        {
            this.Model = model;
            this.FuelAmount= fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TravelledDistance = travelledDistance;
        }

        public void Drive(double km)
        {
            if (km * FuelConsumptionPerKilometer <= FuelAmount)
            {
                FuelAmount-= km * FuelConsumptionPerKilometer;
                TravelledDistance += km;
            }
            else{Console.WriteLine("Insufficient fuel for the drive");}
        }

    }
}
