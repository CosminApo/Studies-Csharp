using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            W();
            R();
        }

        static void R()
        {
            string line;
            StreamReader file = new StreamReader("test.txt"); //open files @ path
            while ((line = file.ReadLine()) != null) //reads line
            {
                Console.WriteLine(line); //prints out line
            }

            file.Close(); //always close file once you're done with it
            Console.ReadKey();
        }
        static void W()
        {
            string line = "hi"; 
            StreamWriter file = new StreamWriter("test.txt", true); //opens file @ path, true condition = no override
            file.WriteLine(line); // write line in file

            file.Close(); //close file
        }
    }
}
