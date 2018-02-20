using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TP2assesment
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int CalculatedDigit = 0;
            int[] ISBN = new int [13];

            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine("Please enter the next digit of ISBN");
                ISBN[i] = Convert.ToInt32(Console.ReadLine());
            }

            while (count < 13
                )
            {
                CalculatedDigit = CalculatedDigit + ISBN[count];
                count++;
                CalculatedDigit = CalculatedDigit + ISBN[count] * 3;
                count++;

            }
            while (CalculatedDigit >= 10)
            {
                CalculatedDigit = CalculatedDigit - 10;
            }
            CalculatedDigit = 10 - CalculatedDigit;
            if (CalculatedDigit == 10)
            {
                CalculatedDigit = 0;
            }
            if (CalculatedDigit == ISBN[12])
            {
                Console.WriteLine("Valid ISBN");
            }
            else
            {
                Console.WriteLine("Invalid ISBN");            
            }
            Console.ReadKey();           
        }
    }
}
