using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pseudo_to_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your word separating every letter by blank spaces");
            string userInp = Console.ReadLine();
            string[] myArr = userInp.Split(' ');
            string[] myArr2 = new string[myArr.Length];
            int anti = myArr.Length - 1;
            int counter = 0;

            for (int i = 0; i < myArr.Length; i++)
            {
                myArr2[i] = myArr[i];
            }

            for (int i = 0; i < myArr.Length; i++)
            {
                if (myArr2[anti] == myArr[i])
                {
                    counter++;
                    anti--;
                }
            }

            if (counter == myArr.Length)
            {
                Console.WriteLine("It is a palindrome");
            }
            else if (counter != myArr.Length)
            {
                Console.WriteLine("It is a not a palindrome");
            }
            Console.ReadKey();
        }
    }
}
