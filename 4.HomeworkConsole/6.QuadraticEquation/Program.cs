using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ax^2 +b+c=0");
            Console.WriteLine("give me a:");
            double? x1 = null;
            double? x2 = null;
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("give me b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("give me c:");
            double c = double.Parse(Console.ReadLine());
            double D = (b * b) - (4 * a * c);
            if (D == 0)
            {
                x1 = (-b - Math.Sqrt(D))/(2*a);
                
            }
            if (D>0)
            {
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);
            }
            if ((x1 == null) && (x2 == null))
            {
                Console.WriteLine("No real Roots");
                
            }
            if ((x1 == null) ^ (x2 == null))
            {
                Console.WriteLine("one root: {0}",x1);
            }
            if ((x1 != null) && (x2 != null))
            {
                Console.WriteLine("two roots : {0} and {1}",x1,x2);
            }
        }
    }
}
