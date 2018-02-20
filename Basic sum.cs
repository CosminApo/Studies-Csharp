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
            int First;
            int Second;
            int Total;

            Console.WriteLine("Insert a number ");
            First=Convert.ToInt32 ( Console.ReadLine()) ;
            Console.WriteLine("One more ");
            Second=Convert.ToInt32 ( Console.ReadLine()) ;
            Total=First+Second;

            Console.WriteLine("Their total is");
            Console.WriteLine(Total);
            Console.ReadKey();
            


        }
    }
}
