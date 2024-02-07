using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Engine
    {
        /*•	Model: a string property
           •	Power: an int property
           •	Displacement: an int property, it is optional
           •	Efficiency: a string property, it is optional
           */
        private string model;
        private int power;
        private int displacement;
        private string efficiency;
        public string Model { get; set; }
        public int Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine()
        {
            Displacement = "n/a";
            Efficiency = "n/a";
        }
        public Engine(string model, int power) : this()
        {
            Model = model;
            Power = power;
            
        }

        public override string ToString()
        {
            return $"{Model}:\r\n" +
                   $"   Power: {Power}\r\n" +
                   $"   Displacement: {Displacement}\r\n" +
                   $"   Efficiency: {Efficiency}";
        }
    }
}
