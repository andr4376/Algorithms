using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    static class BubbleSort
    {

        public static List<int> BubbleSortList<T>(List<int> list)
        {

            List<int> tmp = list;

            int temp = 0;

            for (int write = 0; write < tmp.Count; write++)
            {
                for (int sort = 0; sort < tmp.Count - 1; sort++)
                {
                    if (tmp[sort] > tmp[sort + 1])
                    {
                        temp = tmp[sort + 1];
                        tmp[sort + 1] = tmp[sort];
                        tmp[sort] = temp;

                        PrintCollection(tmp);

                    }
                }
            }

            return tmp;
        }

        private static void PrintCollection(List<int> list)
        {
            Console.Clear();
            foreach (var item in list)
            {
                Console.WriteLine("[" + item + "]");
            }
            Console.WriteLine("\nBubble Sorting");
            System.Threading.Thread.Sleep(50);
        }

        public static void Test()
        {
            Random rnd = new Random();
            List<int> testList = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                testList.Add(rnd.Next(10000000));
            }
            for (int i = 0; i < 5; i++)
            {
                testList.Add(rnd.Next(100000));

            }
            for (int i = 0; i < 5; i++)
            {
                testList.Add(rnd.Next(10000));

            }
            for (int i = 0; i < 5; i++)
            {
                testList.Add(rnd.Next(1000));

            }

            for (int i = 0; i < 5; i++)
            {
                testList.Add(rnd.Next(100));
            }



            testList = BubbleSort.BubbleSortList<int>(testList);
        }
    }
}
