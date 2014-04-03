using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SumFIveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] numbers =a.Split(' ');
            double sum = 0;
            foreach (var item in numbers)
            {
                sum += double.Parse(item);
            }
            Console.WriteLine(sum);
           
        }
    }
}
