using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tribonacci
{
    class Tribonacci
    {
        static void Main(string[] args)
        {
            // I run out of beer !
            BigInteger x1 = BigInteger.Parse(Console.ReadLine());
            BigInteger x2 = BigInteger.Parse(Console.ReadLine());
            BigInteger x3 = BigInteger.Parse(Console.ReadLine());
            BigInteger n = BigInteger.Parse(Console.ReadLine());


            if (n == 1)
            {
                Console.WriteLine(x1);

            }
            else
            {
                if (n == 2)
                {
                    Console.WriteLine(x2);

                }
                else
                {

                    if (n == 3)
                    {
                        Console.WriteLine(x3);

                    }
                    else
                    {

                        BigInteger result = new BigInteger();
                        for (int i = 3; i < n; i++)
                        {
                            result = x1 + x2 + x3;
                            x1 = x2;
                            x2 = x3;
                            x3 = result;
                        }
                        Console.WriteLine(result);
                    }
                }

            }
        }
    }
}  
         

          

        
    
