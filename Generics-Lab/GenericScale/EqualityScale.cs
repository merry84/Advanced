using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace GenericScale
{
    public class EqualityScale<T> where T : IComparable// наследява класа IComparable
    {
        private T left;
        private T right;
        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }
        public bool AreEqual() 
        {
            return left.Equals(right);
        }

        /*Create a class EqualityScale<T> that holds two elements – left and right. 
      * The scale should receive the elements through its single constructor:
        •	EqualityScale(T left, T right)
        The scale should have a single method: 
        •	bool AreEqual()
        The greater of the two elements is the heavier. The method should return true, if the elements are equal.
        */

    }
}
