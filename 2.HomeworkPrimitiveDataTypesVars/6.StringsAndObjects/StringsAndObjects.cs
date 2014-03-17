using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
//            Problem 6.	Strings and Objects
//Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
            string a = "Hello";
            string b = "World";
            string c = "Kondio";
            object text = a + " " + b + " " + c;
            c = (string)text;
            Console.WriteLine(c);

        }
    }
}
