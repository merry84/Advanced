using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> stack = new Stack<T>();
        public Box() 
        {
            stack = new Stack<T>();
        }
        //•	void Add(element) – adds an element on the top of the list.
        //•	element Remove() – removes the topmost element.
        //•	int Count { get; }
        public int Count { get { return stack.Count; } }
        
        public void Add(T element)
        {
            stack.Push(element);
        }
        public T Remove()
        {
            return stack.Pop();
        }
    }
}
