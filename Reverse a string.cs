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
            string rv = "e,s,r,e,v,e,r";
            Console.WriteLine(rv);
            string[] rp = rv.Split(',');
            for (int i = rp.Length - 1; i >= 0; i--)
            {
                Console.Write(rp[i]);
            }
            Console.ReadKey();
        }
    }
}
