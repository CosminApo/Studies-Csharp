using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger bits;
            BigInteger bytes;
            BigInteger kibibytes;
            BigInteger mebibyes;

            Console.WriteLine("Please insert the number of bits");
            bits = Convert.ToInt64(Console.ReadLine());

            bytes = bits / 8;
            kibibytes = bytes / 1024;
            mebibyes = kibibytes / 1024;


            Console.WriteLine("{0, 20} bits is equal to (to the closest significant figure):", bits);
            Console.WriteLine("{0, 20} bytes", bytes);
            Console.WriteLine("{0, 20} kibibytes", kibibytes);
            Console.WriteLine("{0, 20} mebibytes", mebibyes);

            Console.ReadKey();
        }
    }
}
