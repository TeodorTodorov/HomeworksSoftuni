using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace TheFuckedProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            // this problem is sucks , because i run out of beer, but it looks easy and after I solve it i go to buy beer :@
            int n =  int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            foreach (int item in nums)
            {
                int p = item;
                string bitsOFp = Convert.ToString(p, 2);
                StringBuilder str = new StringBuilder();
                for (int i = bitsOFp.Length - 1; i >= 0; i--)
                {
                    str.Append(bitsOFp[i]);
                }
                int Preversed = Convert.ToInt32(str.ToString(), 2);
                
                StringBuilder str2 = new StringBuilder();
                for (int i = 0; i < bitsOFp.Length; i++)
                {
                    if (bitsOFp[i] == '1')
                    {
                        str2.Append("0");
                    }
                    if (bitsOFp[i] == '0')
                    {
                        str2.Append("1");
                    }
                }
                int pInverted = Convert.ToInt32(str2.ToString(), 2);
                
                Console.WriteLine((p^pInverted)&Preversed);
                
            }
            

           

        }
    }
}
