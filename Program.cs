using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaStudy1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listofnumbers = { 0, 2, 13, 14, 16 };
            int oddnumbers = listofnumbers.Count(x => x % 2 != 0);
            Func<int, int> addone =  x => x + 1;
            oddnumbers = addone(oddnumbers);
            Func<int, int, int> multiply = (x, y) => x * y;
            oddnumbers = multiply(oddnumbers, 2);
            Console.WriteLine(oddnumbers);

            Console.ReadLine();
        }
    }
}
