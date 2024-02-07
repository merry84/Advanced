using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxОfString
{
    public class Box<T>
    {
        private List<T>values;
        public Box() 
        {
            this.values = new List<T>();
        }
        public void Add(T value)
        {
            this.values.Add(value);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in this.values)
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                sb.AppendLine($"{item.GetType()}: {item}");
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
            return sb.ToString();
        }
    }
}   
