using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9SequencePrint
{
    class Sequence
    {
        static void Main(string[] args)
        {
            // we check are the numbers odd or event with if else if construction
            // we assign to print variable our result and print it
            // if = ako 
            // else = v protiven sluchai (ako if e greshen )
            // if (lajica), lajica - uslovie ako e vqrno se izpulnqva tqloto na if ako ne e 
            // se izpulnqva else
            //  else if - if the if is false , go into else and in else check 2nd if
            int i = 2;
            int print = 0;
            do
            {
                if (i%2==0)
                {
                    print = i;
                }
                else if(i%2!=0)
                {
                    print = -i;
                }
                i++;

                Console.WriteLine(print);
            } while (i <12);
        }
    }
}
