using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DoubleOrFloat
{
    class DoubleFloat
    {
        static void Main(string[] args)
        {
           //Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? Write a program to assign the numbers in variables and print them to ensure no precision is lost
            float f1 =12.345f;
            float f2 = 3456.091f;
            double d1 = 34.567839023 ;
            double d2 =8923.1234857 ;
            Console.WriteLine("Doubles: {0}, {1} \n\rFLoats: {2}, {3}",d1,d2,f1,f2);
        }
    }
}
