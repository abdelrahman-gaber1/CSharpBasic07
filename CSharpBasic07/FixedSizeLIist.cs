using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace CSharpBasic07
{
    internal class FixedSizeLIist<T>
    {
        T[] values;
        private int count; 
        
        public FixedSizeLIist(int fixedCapacity)
        {
            if (fixedCapacity < 0)
                throw new ArgumentOutOfRangeException(nameof(fixedCapacity));
            else
            values = new T[fixedCapacity];
            count = 0;
        }
        int Capacity => values.Length;
        public void AddElement(T element)
        {
            if (count >= Capacity)
                throw new Exception("list is already full");
            else
                values[count++] = element;
        }
        public  T Get (int index)
        {
            if (index >= Capacity || index < 0)
                throw new Exception("invalid indices");
            else
                return values[index];
        }
    }
}
