using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ThirdDigitIsSeven
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enetr integer:");
            string number = (Console.ReadLine());
            if (number.Length<3)
            {
                Console.WriteLine("nope too short number under 3 digits");
            }

            else if (number[(number.Length-3)]=='7')
            {
                Console.WriteLine("yea {0}",number);
            }
            else
            {
                Console.WriteLine("kochka");
            }
           

        }
    }
}
