using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CirclePerimeterAndArea
{
    class Circle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me radius of the circle:");
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * (radius*radius) ;
            double perimeter = 2 * (Math.PI * radius) ;
            Console.WriteLine("area = {0:0.00}; perimeter = {1:0.00}",area,perimeter);
        }
    }
}
