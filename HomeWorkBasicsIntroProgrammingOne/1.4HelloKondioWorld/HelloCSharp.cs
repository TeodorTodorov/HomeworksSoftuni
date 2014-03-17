using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _1._4HelloKondioWorld
{
    class HelloCSharp
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            // set the console Height
            Console.WindowHeight = 40;
            Console.WriteLine("Hello C# world. ");
            Console.Title = "Rakia and Salad Pepa- siniq prashka, bira vino piandurnici";
            // system sleep is fot the pause between commands in milisecounds
            Thread.Sleep(2000);

            Console.Beep();
            Console.Write("My name is Kondio, and I'm comming from Kondio's world");
            Console.WriteLine("In my world, I'm cool and I listen Kichka Budurova");
            Console.WriteLine("I'm a magician too, do not believe me ? look: ");
            // we are setting some colours in console nothing hard
            Console.BackgroundColor = ConsoleColor.Magenta;
            Thread.Sleep(1000);
            for (int i = 0; i < 10; i++)
            {

                System.Console.WriteLine("a");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Thread.Sleep(400);
                Console.WriteLine("a");

                Console.ForegroundColor = ConsoleColor.Red;
            }
                Thread.Sleep(1000);
                Console.WriteLine("good bye");
        }
    }
}
