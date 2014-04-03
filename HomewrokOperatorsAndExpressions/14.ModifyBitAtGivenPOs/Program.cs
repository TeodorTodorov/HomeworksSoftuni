using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ModifyBitAtGivenPOs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me the integer number:");
            int integer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give em position::");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give me bit: 1 or 0::");
            int bit = Convert.ToInt32(Console.ReadLine());
            int result = 0 ; 
            int mask = 0;
            if (bit == 1)
            {
                 mask = bit << pos;
                result = integer | mask;                
            }
            else if (bit == 0)
            {
                mask = ~(1 << pos);
                result = integer & mask;
            }
            Console.WriteLine(result);
           

        }
    }
}
