using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_change
{
    class Program
    {
        
        static void MultiValues(ref int[] array, int multi)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = multi * array[ i];
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Create a list of values you need to multiply");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("How many values do you want to enter in your list?");
            int numberofvalues = Convert.ToInt32(Console.ReadLine());
            int[] list = new int [numberofvalues]; 

            for (int i = 0; i < list.Length; i++)
            {
                int slot = i + 1;
                Console.WriteLine("Please insert the value in slot " + slot);
                list[i]  = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Please insert your multiplier");
            int multiplier = Convert.ToInt32(Console.ReadLine());

            MultiValues(ref list, multiplier); //values passed both by ref and by value

            for (int i = 0; i < list.Length; i++)
            {
                int slot = i + 1;
                Console.WriteLine("The value in slot  " + slot + " is now " + list[i]);
            }
            Console.ReadKey();
        }
    }
}
