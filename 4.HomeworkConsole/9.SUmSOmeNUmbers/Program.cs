using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.SUmSOmeNUmbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] kondio = new double[n];
            for (int i = 0; i < n; i++)
            {
                kondio[i] = double.Parse(Console.ReadLine());
            }
            double sum = kondio.Sum();
            Console.WriteLine(sum);
        }
    }
}
