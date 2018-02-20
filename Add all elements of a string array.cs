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
            //I've used a splitted string to get the information
            string information = "1 2 3";
            string[] infoArr = information.Split(' ');

            //Converted the string array in an integer array 
            int[] infoInt = Array.ConvertAll(infoArr, int.Parse);

            //Added all the elements together
            int sumOfAll = infoInt.Sum();

            //Testing that it works
            Console.WriteLine(sumOfAll);
            Console.ReadKey();
        }
    }
}
