using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DividedBySevenAndFiveAtSameTimeQuest
{
    class SevenFiveChecker
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 35 == 0)
            {
                Console.WriteLine("KOndio says: COuld be divided by 7 and 5 at same time, the number was : {0}",number);
            }
            else
            {
                Console.WriteLine("Kondio says Mcdonalds, I could not divide it I'm stupid");
            }
        }
    }
}
