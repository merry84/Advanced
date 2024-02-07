using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapMethodInteger
{
    public class Box<T>
    {
        private List<T> values;

        public Box()
        {
            this.values = new List<T>();
        }

        public void Add(T value)
        {
            this.values.Add(value);
        }

        public void Swap(int first, int second)
        {
            var temp = this.values[first];
            this.values[first] = this.values[second];
            this.values[second] = temp;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in values)
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                sb.AppendLine($"{item.GetType()}: {item}");
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
            return sb.ToString();
        }
    }
}
