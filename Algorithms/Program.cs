using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 20;
            CustomArray arrOfNums = new CustomArray(size);

            CustomArray sortedArray = new CustomArray(size);
            Random rnd = new Random(100);
            for (int i = 0; i < size; i++)
            {
                arrOfNums.Insert((int)(rnd.NextDouble() * 100));
            }

            BubbleSort bs = new BubbleSort(arrOfNums);
            bs.Sort();            
            Console.ReadLine();
        }
    }
}
