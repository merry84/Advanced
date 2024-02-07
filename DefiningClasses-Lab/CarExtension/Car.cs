namespace CarManufacturer
{
    public class Car
    {
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
        { get {  return fuelQuantity; } set {  fuelQuantity = value; } } 

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
                fuelQuantity-= distance * fuelConsumption;
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