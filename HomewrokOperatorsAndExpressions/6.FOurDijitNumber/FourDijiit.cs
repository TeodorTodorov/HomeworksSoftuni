using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.FOurDijitNumber
{
    class FourDijiit
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int sum = 0;
            char[] reversed = a.ToArray();
            Array.Reverse(reversed);
            int[] exchange = new int[4];
            foreach (var item in a)
            {
                sum += Convert.ToInt32(item.ToString());
            }
            Console.WriteLine(sum);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(reversed[i]);
                exchange[i] = Convert.ToInt32(a[i].ToString());

            }
            List<int> gosho = exchange.ToList();
            gosho.Insert(0, gosho[3]);
            gosho.RemoveAt(4);
            Console.WriteLine("exchange");
            exchange[1] += exchange[2];
            exchange[2] = exchange[1] - exchange[2];
            exchange[1] = exchange[1] - exchange[2];
            foreach (var item in exchange)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("DABC");
            foreach (var item in gosho)
            {
                Console.WriteLine(item);
            }
            


         
        }
    }
}
