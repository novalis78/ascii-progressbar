using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsciiProgressBar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Ascii Bar");
            AsciiBar ab = new AsciiBar(2);
            for (int x = 1; x <= 12345; x++)
            {
                ab.AsciiProgressBar(12345, x);
                System.Threading.Thread.Sleep(1);
            }
            Console.ReadLine();
        }
    }
}
