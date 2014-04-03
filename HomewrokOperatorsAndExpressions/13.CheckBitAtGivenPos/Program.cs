using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CheckBitAtGivenPos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("position:");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("number:");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isBitAtPositionOne = ((((1 << pos) & num)>>pos)==1);
            Console.WriteLine(isBitAtPositionOne);

        }
    }
}
