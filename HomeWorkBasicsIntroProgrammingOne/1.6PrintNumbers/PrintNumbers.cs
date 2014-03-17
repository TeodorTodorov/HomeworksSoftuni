using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6PrintNumbers
{
    class PrintNumbers
    {
        static void Main(string[] args)
        {
            // just a simple for loop with string concatination (+)
            // 1, 5 , 9 in binary are 1 , 101 , 1001 so we are changing the i with 4 now with 1
            // we convert to 01  and print the binary
            for (int i = 1; i < 10 ; i+=4)
            {
                Console.WriteLine(Convert.ToString(i,2));
            }
            /* or just 
             Console.WriteLine("1");
             *  Console.WriteLine("101");
             *   Console.WriteLine("1001");
             */
        }
    }
}
