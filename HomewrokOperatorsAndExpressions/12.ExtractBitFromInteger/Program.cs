using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ExtractBitFromInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me index (I'm Kondio and count from zero) :");
            int position = Int32.Parse(Console.ReadLine());
            Console.WriteLine("give me our Integer I order you :");
            
            int num = Int32.Parse(Console.ReadLine());
            int mask = 1 <<position;
            int result = mask & num;
            result = result>>position;
            Console.WriteLine(result);

        }
    }
}
