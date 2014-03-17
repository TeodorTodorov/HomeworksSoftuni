using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.VarExchange
{
    class Exchange
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("before: a= {0}; b = {1};",a,b);
             a += b;
             b = a - b;
             a = a - b;
             Console.WriteLine("after: a= {0}; b = {1};", a, b);
        }
    }
}
