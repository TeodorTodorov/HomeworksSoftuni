using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._16PrintSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(100, 1003);
            for (int i = 1; i < 1001; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }
                
            }

        }
    }
}
