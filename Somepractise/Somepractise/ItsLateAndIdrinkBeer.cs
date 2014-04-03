using System;


namespace Somepractise
{
    class Beer
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            int result = Checker(x, y);
            Console.WriteLine(result);
        }
        static int Checker(double x, double y)
        {
            if (x == 0 && y == 0)
            {
                return 0 ;
            }
            else if ( y == 0 )
            {
                return 5;
            }
            else if (x == 0)
            {
                return 6;
            }
            else if (y > 0 && x>0)
            {
                return 1;
            }
            else if (y > 0 && x < 0)
            {
                return 2;
            }
            else if (y < 0 && x < 0)
            {
                return 3;
            }
            else if (y < 0 && x > 0)
            {
                return 4;
            }
            else
            {
                return -1;
            }

        }
    }
}
