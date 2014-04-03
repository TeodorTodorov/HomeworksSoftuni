using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.PrimeNumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int count = 0;
            bool primary = true;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    primary = false;
                    count++;
                   
                }
              
            }
           
            Console.WriteLine("IS pRImary: {0}",primary);
            
        }
    }
}
