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
            string one = "oneoneone";
            string two = "       twotwotwo";

            Console.WriteLine(one);
            Console.WriteLine(two);

            Console.WriteLine();
            Console.WriteLine("----CONCATENTION---");

            //Concatentation
            string three = one + two;
            Console.WriteLine(three);

            Console.WriteLine();
            Console.WriteLine("----TRIMMING---");

            // Trimming whitespace
            two = two.Trim();
            Console.WriteLine(two);

            Console.WriteLine();
            Console.WriteLine("----LENGTH---");

            // Length
            int chars = two.Length;
            Console.WriteLine(chars.ToString());

            Console.WriteLine();
            Console.WriteLine("----CHARACTER LOCATIONS---");

            // Print a random character in the string
            // Generates a random number between 0 and the length of two( the "-1" used to remove array overflow)
            Random r = new Random();
            int rn = r.Next(0, two.Length - 1);
            Console.WriteLine(two[rn]);

            Console.WriteLine();
            Console.WriteLine("----CAPITALISATION---");

            // Change the capitalisation
            string four = one.ToUpper();
            Console.WriteLine(four);
            
            Console.WriteLine();
            Console.WriteLine("----SEARCHING---");

            // Find a string
            if (two.Contains("two"))
            {
                Console.WriteLine(two + " contains the smaller string 'two'"); 
            }
            else
            {
                Console.WriteLine(two + " does not contain the smaller string 'two'");
            }

            Console.WriteLine();
            Console.WriteLine("----SPLITTING---");

            // Splitting a string in to an array
            string five = "Today is a very sunny day for winter";
            // Changes to a new array index every time a "," is encountered
            string[] numbers = five.Split(' ');
            Console.WriteLine("\" "+five+ " \"");
            Console.WriteLine("There are " + numbers.Length + " words in this sentence.");
            //for (int i = 0; i <= numbers.Length - 1; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            Console.ReadKey();                       

        }
    }
}
