using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BubbleSort
    {
        private CustomArray arrOfNumbers;
        public BubbleSort(CustomArray numbers)
        {
            arrOfNumbers = numbers;
        }

        public void Sort()
        {
            int temp;
            int upper = arrOfNumbers.upper;
            for (int outer = upper; outer > 1; outer--)
            {
                for (int inner = 0; inner < outer; inner++)
                {
                    if (arrOfNumbers.NumArray[inner] > arrOfNumbers.NumArray[inner + 1])
                    {
                        temp = arrOfNumbers.NumArray[inner];
                        arrOfNumbers.NumArray[inner] = arrOfNumbers.NumArray[inner + 1];
                        arrOfNumbers.NumArray[inner + 1] = temp;
                    }
                    arrOfNumbers.DisplayElements();
                    Console.WriteLine();
                }
                
            }

            
        }
    }
}
