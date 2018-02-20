using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int doorchoice;

            Console.WriteLine("One of the door will lead you to victory, the others will make you loose");
            Console.WriteLine("Choose wisely! (1-3)");
            doorchoice = Convert.ToInt32(Console.ReadLine());
            switch (doorchoice)
            {
                case 3:
                    functwin();
                    break;
                case 2:
                    functlose();
                    break;
                case 1:
                    functlose();
                    break;

            }
        }
        static void functwin()
        {
            Console.WriteLine("You chose well...");
            Console.ReadKey();
        }

        static void functlose()
        {
            Console.WriteLine("You chose poorly...");
            Console.ReadKey();
        }
    
    }

}
