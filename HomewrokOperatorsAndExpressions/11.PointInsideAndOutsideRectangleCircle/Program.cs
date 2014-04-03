using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PointInsideAndOutsideRectangleCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            uint a = uint.Parse(Console.ReadLine());
            uint mask = 1 << 3;
            uint result = a & mask;
            Console.WriteLine(result>>3);
        }
    }
}
