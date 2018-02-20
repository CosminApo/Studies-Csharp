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
            //Have to declare the variables outside the while loop, or they would be reassigned
            string[] list = { "one", "two", "three", "four", "five" };
            bool happy = true;
            while (happy == true)
            {

                bool assign = false;
                int listspot = 0;
                bool error = false;
                Console.WriteLine("Enter what you want to search");
                string search = Console.ReadLine();
                for (int i = 0; i < array.length ; i++)
                {
                    Console.WriteLine(i);
                    if (search == list[i])
                    {
                        error = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(list[i]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    }

                }
                if (error == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(search + " is not on this list");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.WriteLine("Do you want to try again (true) or not (false)");
                //User input had to be converted to fit the type
                happy = Convert.ToBoolean(Console.ReadLine());
                if (happy == false)
                {
                    Console.WriteLine("Do you want to assing that value to one of the 5 list spots? (true or false)");
                    assign = Convert.ToBoolean(Console.ReadLine());
                }
                if (assign == true)
                {
                    Console.WriteLine("Which position (1-4)");
                    listspot = Convert.ToInt32(Console.ReadLine());
                    list[listspot] = search;
                    Console.WriteLine("Would you like to test it?(true or false)");
                    happy = Convert.ToBoolean(Console.ReadLine());
                    happy = true;

                }
                else if (assign == false)
                {
                    Console.WriteLine("Good Bye");
                    happy = false;
                }

            }
            Console.ReadKey();


        }
    }
}
