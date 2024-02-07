
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Tire
    {
        //•	Tires: a collection of exactly 4 tires. Each tire should have two properties: age and pressure.
        private double pressure;
        private int age;
        public double Pressure { get; set; }
        public int Age { get; set; }

        public Tire(double pressure, int age)
        {
            Pressure = pressure;
            Age = age;
        }
    }
}
