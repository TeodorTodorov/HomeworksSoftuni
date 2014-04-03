using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GLass
{
    class KureGlassDraw
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dots = 0;
            int special = n;
            for (int i = 0; i < (n/2)+1; i++)
            {
                Draw(dots, special);
                dots++;
                special -= 2;
                
            }
            special = 3;
            dots = n / 2 -1 ;
            for (int i = 0; i < (n / 2); i++)           
            {
                Draw(dots, special);
                dots--;
                special += 2;

            }
        }
  

            static void Draw (int dots, int special)
            {
                Console.WriteLine(new string('.', dots) + new string('*', special) + new string('.', dots));
            }

        }
    }

