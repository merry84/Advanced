using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodDouble
{
    public class Box<T> where T : IComparable<T>
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

        public int GetCount(T valueToCompare)
        {
            int count = 0;
            foreach (T value in this.values)
            {
                if (value.CompareTo(valueToCompare) > 0)//ако елемента отдясно не е по-голям връща -1, ако връща положително число то стринга е по-голям. Ако върне 0, значи са еднакви
                    count++;
            }
            return count;
        }
        

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var v in this.values)
            {
                sb.AppendLine($"{v.GetType()}: {v}");
            }

            return sb.ToString();
        }
    }
}
