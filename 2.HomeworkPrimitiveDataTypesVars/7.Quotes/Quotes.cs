using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Quotes
{
    class Quotes
    {
        static void Main(string[] args)
        {
            string someText = "The \"use\" of quotations causes difficulties.";
            string someText2 = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(someText);
            Console.WriteLine(someText2);
        }
    }
}
