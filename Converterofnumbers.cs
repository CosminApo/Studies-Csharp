using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static class vars
        {
            public static int conv;
            public static int hd;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please select your option 1-10");
            menu();
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    bintoden();
                    break;
                case 2:
                    dentobin();
                    break;
                case 3:
                    bintohex();
                    break;
                case 4:
                    dentohex();
                    break;
                case 5:
                    hextoden();
                    break;
                case 6:
                    hextobin();
                    break;
                case 7:
                    anytoden();
                    break;
            }
        }
        static void menu()
        {
            Console.WriteLine("1. Binary to Denary");
            Console.WriteLine("2. Denary to Binary");
            Console.WriteLine("3. Binary to Hex");
            Console.WriteLine("4. Denary to Hex");
            Console.WriteLine("5. Hex to Denary");
            Console.WriteLine("6. Hex to Binary");
            Console.WriteLine("7. Any to Denary");
            Console.WriteLine("8. Exit");
        }
        static void dentobin()
        {
            int usern;
            if (vars.hd != 0)
            {
                usern = vars.hd;
            }
            else
            {
                Console.WriteLine("Please enter your number");
                usern = Convert.ToInt32(Console.ReadLine());
            }
            int j=0;
            int[] conv = new int[255];

            for (int i = 0 ; i < conv.Length ; i++)
            {
                if (usern != 0)
                {
                    if (usern % 2 == 0)
                    {
                        conv[i] = 0;
                    }
                    else if (usern % 2 == 1)
                    {
                        conv[i] = 1;
                    }
                    usern = usern / 2;
                    j++;
                }
                
            }
            // Use array.resize so you don't get 255 bits displayed
            Array.Resize(ref conv, j);
            for (int i = conv.Length - 1; i >= 0; i--)
            {


                if (i <= conv.Length)
                {
                    Console.Write(conv[i] + " ");
                }

            }
            Console.ReadKey();
        }
        static void bintoden()
        {
            Console.WriteLine("Please insert your number separated by blank spaces");
            string number = Console.ReadLine();
            string[] stringnumber = number.Split(' ');
            int j = 0;
            int[] stringint = Array.ConvertAll(stringnumber, int.Parse);
            for (int i = stringint.Length - 1; i >= 0; i--)
            {

                stringint[i] = stringint[i] * Convert.ToInt32(Math.Pow(2, j));
                j++;
                
            }
            int sum = stringint.Sum();
            Console.WriteLine(sum + " in Denary");
            Console.ReadKey();
            vars.conv = sum;

        }
        static void bintohex()
        {
            bintoden();
            dentohex();
        }
        static void dentohex()
        {
            int userNumber;
            //allows the functions to work together
            if (vars.conv != 0)
            {
                userNumber = vars.conv;
            }
            else
            {
                Console.WriteLine("Please insert your number");
                userNumber = Convert.ToInt32(Console.ReadLine());
            }
            if (userNumber > 9)
            {
                int convNumber = userNumber / 16;
                string convNumberLetter = "";
                string remainderNumberLetter = "";
                int remainderNumber = userNumber % 16;
                if (convNumber >= 10)
                {
                    switch (convNumber)
                    {
                        case 10:
                            convNumberLetter = "A";
                            break;
                        case 11:
                            convNumberLetter = "B";
                            break;
                        case 12:
                            convNumberLetter = "C";
                            break;
                        case 13:
                            convNumberLetter = "D";
                            break;
                        case 14:
                            convNumberLetter = "E";
                            break;
                        case 15:
                            convNumberLetter = "F";
                            break;
                    }
                    Console.Write(convNumberLetter);

                }
                else
                {
                    Console.Write(convNumber);
                }

                if (remainderNumber >= 10)
                {
                    switch (remainderNumber)
                    {
                        case 10:
                            remainderNumberLetter = "A";
                            break;
                        case 11:
                            remainderNumberLetter = "B";
                            break;
                        case 12:
                            remainderNumberLetter = "C";
                            break;
                        case 13:
                            remainderNumberLetter = "D";
                            break;
                        case 14:
                            remainderNumberLetter = "E";
                            break;
                        case 15:
                            remainderNumberLetter = "F";
                            break;
                    }
                    Console.Write(remainderNumberLetter);
                }
                else
                {
                    Console.Write(convNumber);
                }
            }
            //1-9 in denary = 1-9 in hex
            else
            {
                Console.Write(userNumber);
            }
            Console.Write(" in Hex");
            Console.ReadKey();
        }
        static void hextoden()
        {
            Console.WriteLine("Please insert your number separated by blank spaces");
            string userInp = Console.ReadLine();
            int j = 0;
            string[] userInpArr = userInp.Split(' ');

            if (userInp.Contains("A") || userInp.Contains("B") || userInp.Contains("C") || userInp.Contains("D") || userInp.Contains("E") || userInp.Contains("F"))
            {
                for (int i = 0; i < userInpArr.Length; i++)
                {
                    switch (userInpArr[i])
                    {
                        case "A":
                            userInpArr[i] = "10";
                            break;
                        case "B":
                            userInpArr[i] = "11";
                            break;
                        case "C":
                            userInpArr[i] = "12";
                            break;
                        case "D":
                            userInpArr[i] = "13";
                            break;
                        case "E":
                            userInpArr[i] = "14";
                            break;
                        case "F":
                            userInpArr[i] = "15";
                            break;
                    }
                }
            }
            int[] intArr = Array.ConvertAll(userInpArr, int.Parse);
            for (int i = intArr.Length - 1; i >= 0; i--)
            {
                intArr[i] = intArr[i] * Convert.ToInt32(Math.Pow(16, j));
                j++;
            }
            int finalResult = intArr.Sum();
            Console.WriteLine("Your number is " + finalResult + " in Denary");
            vars.hd = finalResult;
            Console.ReadKey();
        }
        static void hextobin()
        {
            //to make the code shorter use previous functions
            hextoden();
            dentobin();
        }
        static void anytoden()
        {
            // This function doesn't allow letters, so bases above 10 have to use the converted number
            Console.WriteLine("Please insert your number separated by a white space.");
            int convN;
            string usern = Console.ReadLine();
            
            Console.WriteLine("Please insert your base");
            int choiceofbase = Convert.ToInt32(Console.ReadLine());
            string[] usernArr = usern.Split(' ');
            
            for (int i = usernArr.Length - 1; i >= 0; i--)
            {
                int test = Convert.ToInt32(Math.Pow(choiceofbase, i));
                convN = Convert.ToInt32(usernArr[i]) * test;
                usernArr[i] = Convert.ToString(convN);
            }
            
            int[] usernArrint = Array.ConvertAll(usernArr, int.Parse);
            int sumofall = usernArrint.Sum();
            Console.WriteLine("Your number in base " + choiceofbase + " is equal to " + sumofall + " in base 10 (denary)");
            Console.ReadKey();
        }

    }
}
