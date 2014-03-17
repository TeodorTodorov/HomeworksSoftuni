using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.PodecimalInCircle
{
    class CIrcleCheker
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Y=:");
            decimal y = decimal.Parse(Console.ReadLine());
            Console.WriteLine("X=:");
            decimal x = decimal.Parse(Console.ReadLine());
            if (x<0)
            {
                x = -x;
            }
            if (y<0)
            {
                y = -y;
            }
            if (x*x + y*y <2*2)
            {
                Console.WriteLine("InCIrcle");
                
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
