using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PointInsideOutside
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("x=:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("y=:");
            double y = double.Parse(Console.ReadLine());
           bool circleCheck = CircleChecker(x, y);
           bool RectangleCheck = OutOfRectangle(x, y);
           if (circleCheck && RectangleCheck)
           {
               Console.WriteLine("YEa");
           }
           else 
           {
               Console.WriteLine("Nope");
           }

           
        }
        static bool CircleChecker(double x, double y)
        {
            double circlex = x - 1;
            double cirley = y - 1;
            bool inCurcle = false;
            if (x < 0)
            {
                circlex = -circlex;
            }
            if (cirley < 0)
            {
                cirley = -cirley;
            }
            if (circlex * circlex + cirley * cirley <= 1.5 * 1.5)
            {
                inCurcle = true;


            }
            else
            {
                inCurcle = false;
            }
            return inCurcle;
        }

        static bool OutOfRectangle(double x, double y)
        {
            if (x<-1 || x>5 )
            {
                return true;
            }
           
            if (y >1 || y<-1)
            {
                return true;
                
            }
            if (x >= 1 && x <= 5 && (y > 1 || y < -1))
            {
                return true;
            }
            if (y < 1 && y <= -1 && (x < 1 || x > 5))
            {
                return true;
            }
            else
            {

                return false;
            }
            
        }
    }
}
