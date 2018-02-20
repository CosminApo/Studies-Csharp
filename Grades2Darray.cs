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
            int choice;
            bool happy= false;
            string[,] studentgrades = new string [5, 2];
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Please insert student name");
                studentgrades[i, 0] = Console.ReadLine();
                Console.WriteLine("Please insert student grade");
                studentgrades[i, 1] = Console.ReadLine();
            }

            while (happy == false)
            {
                Console.WriteLine("Do you want to change any? (True / False)");
                happy = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Which one? (1,5)");
                choice = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("Please insert the new grade");
                studentgrades[choice, 1] = Console.ReadLine();
                for (int j = 0; j <= 4; j++)
                {
                    Console.WriteLine("The student " + studentgrades[j, 0] + " Has the grade " + studentgrades[j, 1]);
                }
                Console.WriteLine("Is it okay now? (True / False)");
                happy = Convert.ToBoolean(Console.ReadLine());
            }
            while (happy == true)
            {
                Console.WriteLine("Good Bye!");
                break;
            }

            Console.ReadKey();

        }
    }
}
