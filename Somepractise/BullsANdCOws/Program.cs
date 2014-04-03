using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsANdCOws
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretnumber = int.Parse(Console.ReadLine());
            int bulls = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int?[] secretCopy = new int?[4];
            bool write = false;
            
                secretCopy[0] = secretnumber % 10;
                secretCopy[1] = ((secretnumber % 100) - secretnumber % 10)/10;
                secretCopy[2] = (secretnumber % 1000) / 100;
                secretCopy[3] = (secretnumber % 10000) / 1000;
                secretCopy.Reverse();
                int?[] secret = secretCopy.Reverse().ToArray();


                for (int i = 1; i <= 9; i++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        for (int n = 1; n <=9; n++)
                        {
                            for (int k = 1; k <=9; k++)
                            {
                                int?[] nums = new int?[] { i, j, n, k };
                                int cowsCount = 0;
                                int bullsCount = 0;
                                List<int?> clone = new List<int?> {secret[0],secret[1],secret[2],secret[3] };
                                
                                
                                for (int p = 0; p <= 3; p++)
                                {
                                    if (nums[p]== clone[p] && (nums[p] != null))
                                    {
                                        bullsCount++;
                                        nums[p] = null;
                                        clone[p] = null;
                                    }

                                    
                                }
                                for (int p = 0; p < 4; p++)
                                {
                                    for (int z = 0; z < 4; z++)
                                    {
                                        if ((nums[p] == clone[z]) && (nums[p] !=null) && (p !=z))
                                        {
                                            cowsCount++;
                                            nums[p] = null;
                                            clone[z] = null;
                                            
                                        }
                                    }
                                    
                                }
                                if ((bulls == bullsCount) && (cowsCount == cows))
                                {
                                    
                                    Console.Write("{0}{1}{2}{3} ",i,j,n,k);
                                    write = true;
                                }
                             
                               
                                
                            }
                            
                        }
                    }
                }

                if (!write)
                {
                    Console.Write("No");
                }
        }
        
    }
}
