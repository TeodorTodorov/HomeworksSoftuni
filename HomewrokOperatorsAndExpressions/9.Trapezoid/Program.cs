using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Trapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me your Height");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("GIve me your side a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Give me your side b");
            double b = double.Parse(Console.ReadLine());
            double area = ((a + b) / 2.0) * height;
            Console.WriteLine("the area is {0}",area);
        }
    }
}
