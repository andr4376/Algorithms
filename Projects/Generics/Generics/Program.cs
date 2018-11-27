using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            MyLinkedList<int> linkedList = new MyLinkedList<int>();

            linkedList.AddToEnd(1);
            linkedList.AddToEnd(2);
            linkedList.AddToEnd(3);
            linkedList.AddToEnd(4);
            linkedList.AddToEnd(5);
            linkedList.AddToBeginning(6);
            linkedList.AddToEnd(7);





            foreach (int item in linkedList)
            {
                Console.Write("[" + item + "] ->");
            }
            Console.ReadKey();
        }




































































        //GENERIC METHODS EXAMPLES



        private static void GenericsExamples()
        {
            //  Generic methods kan både tage værdityper og reference typer med i dens parametre
            GenericMethod<int>(5, 7);
            GenericMethod<string>("Andreas", " Jensen");
            //Fungere ligesom List<T>, hvor man skal identificere typen den bearbejder.

            //Hvis man ikke gør det, gør den det automatisk
            GenericMethod(5, 7);
            GenericMethod("Andreas", " Jensen");
        }

        /// <summary>
        /// således opbygges en generisk metode
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="first"></param>
        /// <param name="second"></param>
        private static void GenericMethod<T>(T first, T second)
        {

        }

        private static void Swap<T>(T first, T second)
        {
            T tmp = first;
            first = second;
            second = tmp;

        }
    }





}

