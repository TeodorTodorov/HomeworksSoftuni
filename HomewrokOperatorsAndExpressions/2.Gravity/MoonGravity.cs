using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Gravity
{
    class MoonGravity
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm and Alian, my name is Kondio, give your earth-weight you еarthman:");
            int weightEarth = int.Parse(Console.ReadLine());
            Console.WriteLine(weightEarth * 17.0 /100.0);
        }
    }
}
