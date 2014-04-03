using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.PrintNumbersToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(600, 1000);
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
