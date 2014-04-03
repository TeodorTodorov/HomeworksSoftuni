using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HomeworkConsole
{
    class Sum
    {
        static void Main(string[] args)
        {
            int sum = new int() ;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("give me number {0} :",i);
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("sum = {0} ",sum);
        }
    }
}
