using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._0.PlayWithVS
{
    class Program
    {
        static void Main(string[] args)
        {
            // I do not have to write this and you do not to check it, but this is implementation of selection sort algorithm
            // we are using arrays , samo variables and at the end print the entire array with foreach
            int[] kondioNumbers = new int[] { 10, 7, 6, 5, 4, 3, 2, 9, 34, 533 };
            for (int i = 0; i < kondioNumbers.Length; i++)
            {
                int min = int.MaxValue;
                int minPostion = 0;
                //
                for (int j = i; j < kondioNumbers.Length; j++)
                {
                    if (kondioNumbers[j] < min)
                    {
                        min = kondioNumbers[j];
                        minPostion = j;
                    }

                }
                //
                kondioNumbers[minPostion] = kondioNumbers[i];
                kondioNumbers[i] = min;
            }
            foreach (var item in kondioNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
