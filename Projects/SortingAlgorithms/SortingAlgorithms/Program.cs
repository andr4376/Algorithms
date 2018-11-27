using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {




                QuickSort.Test();
                Console.ReadKey();

                List<int> tmp = InsertionSort.Test();
                Console.WriteLine(BiggestNumber.FindBiggestNumber(tmp));
                Console.ReadLine();


                BubbleSort.Test();

                Console.ReadLine();
            }

        }
    }
}
