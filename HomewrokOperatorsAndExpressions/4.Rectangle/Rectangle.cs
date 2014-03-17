using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Rectangle
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter Kondio's rectangle width:");
            double width = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ENter Kondio's rectangle height:");
            double height = Int32.Parse(Console.ReadLine());
            double area = width * height;
            double perimeter = (width + height) * 2;
            Console.WriteLine("Area: {0}; Perimeter: {1}",area,perimeter);
        }
    }
}
