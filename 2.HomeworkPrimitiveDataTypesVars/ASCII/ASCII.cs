using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    class ASCII
    {
        static void Main(string[] args)
        {

            // Set the window size and title
            Console.Title = "Code Page 437: MS-DOS ASCII Characters";

            for (byte b = 0; b < byte.MaxValue; b++)
            {
                char c = Encoding.GetEncoding(1252).GetChars(new byte[] { b })[0];
                switch (b)
                {
                    case 8: // Backspace
                    case 9: // Tab
                    case 10: // Line feed
                    case 13: // Carriage return
                        c = '.';
                        break;
                }

                Console.Write("{0:000} {1}   ", b, c);

                // 7 is a beep -- Console.Beep() also works
                if (b == 7) Console.Write(" ");

                if ((b + 1) % 8 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}