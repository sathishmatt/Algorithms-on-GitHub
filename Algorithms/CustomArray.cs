using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class CustomArray
    {
        private int[] arr;
        public int upper;
        private int numElements;

        public CustomArray(int size)
        {
            arr = new int[size];
            upper = arr.GetUpperBound(0);
            numElements = 0;
        }

        public int[] NumArray
        {
            get { return arr; }
        }

        public void Insert(int num)
        {
            arr[numElements] = num;
            numElements++;
        }

        public void DisplayElements()
        {
            for (int i = 0; i <= upper; i++)
            {
                Console.Write(arr[i] + ";");
            }
        }

        public void Clear()
        {
            for (int i = 0; i <= upper; i++)
            {
                arr[i] = 0;
                numElements = 0;
            }
        }

    }
}
