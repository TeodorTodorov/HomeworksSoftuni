using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Format
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me a:");
            int a = int.Parse(Console.ReadLine());
            string aBinary = Convert.ToString(a, 2);
            Console.WriteLine("give me b:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("give me c:");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("|{0,-10:X}|{1,10}|{2,10:0.00}|{3,-10:0.000}|", a, aBinary.PadLeft(10,'0'), b, c);
            Console.WriteLine(aBinary);

        }
    }
}
