using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Cargo
    {
        //Cargo: a class with two properties – type and weight
        private string type;
        private int weight;

        public string Type { get; set; }
        public int  Weight { get; set; }
        public Cargo(string type, int weight)
        {
            Type = type;
            Weight = weight;
            
        }
    }
}
