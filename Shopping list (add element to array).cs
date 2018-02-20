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
            Console.WriteLine("Insert the amount of items you need to buy");
            int amount = Convert.ToInt32(Console.ReadLine());
            string[] shoppinglist = new string [amount];

                for (int i = 0; i < amount; i++)
                {
                    Console.WriteLine("Assign a value to array " + i);
                    shoppinglist[i] = Console.ReadLine();

                }
                
                Console.WriteLine("Your shopping list now contains");

                for (int j = 0; j < amount; j++)
                {
                    Console.WriteLine(shoppinglist[j]);
                }

                Console.ReadKey();

        }
    }
}
