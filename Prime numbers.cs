using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9th_may
{
    class Program
    {
        static void Main(string[] args)
        {
            int count2;
            string Prime;
            int count1;
            int Maxvalue;
            Maxvalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The first few prime numbers are:");
            for (count1 = 1; count1 <= Maxvalue; count1++)
            {
                count2 = 2;
                Prime = "Yes";
                while ((count2 * count2) <= count1)
                {
                    if ((count1 % count2) == 0)
                    {
                        Prime = "No";
                    }
                    count2++;
                }
                if (Prime == "Yes")
                {
                    Console.WriteLine(count1);
                }
            }
            Console.ReadLine();
           
            
        }
    }
}
