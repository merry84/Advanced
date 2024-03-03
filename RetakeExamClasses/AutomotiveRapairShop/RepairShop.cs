using System;
using System.Text;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        //Next, you are given a class RepairShop that has Vehicles (a List that stores Vehicles).
        //All entities inside the repository have the same properties. The RepairShop class should have the following properties:
        //•	Capacity – int
        //•	Vehicles – List<Vehicle>
        //The class constructor should receive capacity, also it should initialize the Vehicles with a new instance of the collection.
        //Implement the following features:
        //•	Method AddVehicle(Vehicle vehicle) – adds an entity to the collection of Vehicles, if the Capacity allows it.
        //•	Method RemoveVehicle(string vin) – removes a vehicle by given vin, if such exists,
        //and returns boolean (true if it is removed, otherwise – false)
        //•	Method GetCount() – returns the number of vehicles, registered in the RepairShop
        //•	Method GetLowestMileage() – returns the Vehicle with the lowest value of Mileage property.
        //•	Method Report() – returns a string in the following format:
        //o   "Vehicles in the preparatory:
        //{ Vehicle1}
        //{Vehicle2
        //    }
        //    (…)"
        public RepairShop(int capacity)
        {
            Capacity = capacity;
            Vehicles = new List<Vehicle>();
        }
        public int Capacity { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        //Method AddVehicle(Vehicle vehicle) – adds an entity to the collection of Vehicles, if the Capacity allows it.
        //Vehicles.Count < Capacity
        public void AddVehicle(Vehicle vehicle)
        {
            if(Vehicles.Count < Capacity) { Vehicles.Add(vehicle); }
        }
        //Method RemoveVehicle(string vin) – removes a vehicle by given vin, if such exists,
        public bool RemoveVehicle(string vin) => Vehicles.Remove(Vehicles.FirstOrDefault(v=>v.VIN == vin));
        //Method GetCount() – returns the number of vehicles, registered in the RepairShop
        public int GetCount() => Vehicles.Count;
        //Method GetLowestMileage() – returns the Vehicle with the lowest value of Mileage property.
        public Vehicle GetLowestMileage() => Vehicles.OrderBy(v => v.Mileage).FirstOrDefault();
                
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Vehicles in the preparatory:");
            foreach (Vehicle item in Vehicles)
            {
                sb.AppendLine($"{item.ToString()}");  
            }
            return sb.ToString().TrimEnd();
        }

    }
}
