using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Car
    {
       //Create a constructor that receives all of the information about the Car and creates and initializes the model and its inner components (engine, cargo and tires).
     
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;
        public string Model { get; set; }
        public Tire[] Tires { get; set; }
        public Cargo Cargo { get; set; }
        public Engine Engine { get; set; }

        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }
    }
}




