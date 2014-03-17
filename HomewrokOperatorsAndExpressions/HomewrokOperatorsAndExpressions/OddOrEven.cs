using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomewrokOperatorsAndExpressions
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Swapper(a, b);
            int *a = 3;
            int a = 5;
        }
        static void Swapper (int x, int y)
            
        {
           
            x ^= y;
            y ^= x;
            x ^= y;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
