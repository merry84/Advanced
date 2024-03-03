using static System.Net.Mime.MediaTypeNames;

namespace AutomotiveRepairShop
{
    public class Vehicle
    {
        //You are given a class Vehicle with the following properties:
        //•	VIN – string
        //•	Mileage - int
        //•	Damage - string
        //The class constructor should receive vin, mileage and damage.
        //Override the ToString() method in the following format:
        //"Damage: {damage}, Vehicle: {vin} ({mileage} km)"
        public Vehicle(string vin,int mileage,string damage)
        {
            VIN = vin;
            Mileage = mileage;
            Damage = damage;
        }

        public string  VIN { get; set; }
        public int Mileage { get; set; }
        public string Damage { get; set; }
        public override string ToString()
        {
            return $"Damage: {Damage}, Vehicle: {VIN} ({Mileage} km)";
        }
    }
}
