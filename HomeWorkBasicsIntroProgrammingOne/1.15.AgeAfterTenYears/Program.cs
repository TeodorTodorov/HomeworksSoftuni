using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._15.AgeAfterTenYears
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me your birthdate I'm the God of Kondio's world:");
            DateTime ageNow = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            TimeSpan age = (now.Subtract(ageNow));
            
            Console.WriteLine(new DateTime(age.Ticks).Year -1);
            Console.WriteLine(age.Ticks);
            Console.WriteLine("Age after ten years:{0}", (new DateTime(age.Ticks).Year - 1)+10);
           


        }
    }
}
