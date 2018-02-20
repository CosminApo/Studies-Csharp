using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Countdown
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 100;
            while (total > 0) 
            {
                System.Threading.Thread.Sleep(100);

                if (total % 2 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.WriteLine(total); 
                total--;
                
            }
            Console.ReadKey();
        }
    }
}
