using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FIbanocci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(fib(n));

           
        }
        static int fib(int n)
        {
            int fib0 = 0, fib1 = 1;
            for (int i = 2; i <= n; i++)
            {
                int tmp = fib0;
                fib0 = fib1;
                fib1 = tmp + fib1;
            }
            return (n > 0 ? fib1 : 0);
        }
    }
}
