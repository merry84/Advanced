using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threeuple
{
    public class Threeuple<T,V,S>
    {
        public T item1 { get; set; }
        public V item2 { get; set; }
        public S item3 { get; set; }
        public Threeuple(T item1, V item2, S item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public override string ToString()
        {
            return $"{this.item1} -> {this.item2} -> {this.item3}";
        }
    }
}
