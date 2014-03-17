using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PrintMyName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm Gaco Baco the cabbage");
            Console.WriteLine("Whoareyou?:");
            //readline reads one line from console, every read is in string format if i wanna read an int i parse it to int
            // example int a = int.Parse(name);
            // everything we read from console is STRING ee "text"
            string name = Console.ReadLine();
            // "{0} this is something like container and we put name in it"
            Console.WriteLine("OO you are:{0}",name);
           
        }
    }
}
