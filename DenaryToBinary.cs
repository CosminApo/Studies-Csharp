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
            int number = 0;
            int returnValue = 0;
            bool validate = false;
            List<int> binary = new List<int> ();

            while (validate == false)
            {
                try
                {
                    Console.WriteLine("Please insert your denary number");
                    number = Convert.ToInt32(Console.ReadLine());
                    validate = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please insert a valid number");
                }
            }

            while (number != 0)
            {
                int tempnumber = number;
                number = number / 2;
                 returnValue = tempnumber % 2;
                Console.WriteLine("{0} / 2 = {1} remainder {2}", tempnumber, number, returnValue);
                binary.Add(returnValue);
            }

            while (binary.Count < 8)
            {
                binary.Add(0);
            }
            Console.WriteLine("Your number in binary is");
            for (int i = binary.Count -1; i >= 0; i--)
            {
                Console.Write(binary[i]);
            }
            Console.ReadKey();
        }
    }
}
