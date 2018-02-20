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
            Console.WriteLine("Insert your string encoded with RLE (separate elements with ',')");
            string RLEstring = Console.ReadLine().Trim();
            int numberoftimes = 0;
            char letter; 
            string[] RLEseparate = RLEstring.Split(',');
            string decompressedString = "";

            for (int j = 0; j < RLEseparate.Length; j++)
            {
                string tempstring = RLEseparate[j].ToUpper() ;
                numberoftimes = GetNumberoftimes(numberoftimes, RLEseparate, tempstring);
                letter = GetCharr(RLEseparate, tempstring);
                for (int i = 0; i < numberoftimes; i++)
                {
                    decompressedString = decompressedString + letter;
                }
                numberoftimes = 0;
            }

            Console.WriteLine("Your decompressed string is : {0}", decompressedString);
            Console.ReadKey();

        }

        static int GetNumberoftimes(int numberoftimes, string[] RLEseparate, string tempstring)
        {
            string yeawat = "";
            for (int j = 0; j < tempstring.Length; j++)
            {
                if (tempstring[j] > 47 && tempstring[j] < 58)
                {
                    int tempint = Convert.ToInt32(Char.GetNumericValue(tempstring[j]));
                    yeawat = yeawat + Convert.ToString(tempint);             
                }
            }
            numberoftimes = Convert.ToInt32(yeawat);
            return numberoftimes;
        }

        static char GetCharr(string[] RLEseparate, string tempstring)
        {
            char returnvalue = ' ';
            for (int i = 0; i < tempstring.Length; i++)
            {
                if (tempstring[i] > 64 && tempstring[i] < 91)
                {
                    returnvalue = tempstring[i];
                }
            }
            return returnvalue;
        }
    }
}
