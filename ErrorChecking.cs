using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Error_checkin
{

    class Program
    {
        static void Main(string[] args)
        {
            string binarymessage = "";
            bool check = false;
            

            while (check == false)
            {
                Console.WriteLine("Please enter your binary message (2 character minimum)");
                binarymessage = Console.ReadLine();
                int binarycheckone = (int)Char.GetNumericValue(binarymessage[0]);
                int binarychecktwo = (int)Char.GetNumericValue(binarymessage[1]);
                int binarycheckletter = Convert.ToInt32(binarymessage[0]);

                if ((binarycheckone * binarychecktwo) > 1 || binarycheckletter > 49)
                {
                    Console.WriteLine("Only binary numbers are allowed.");
                    Console.WriteLine(""); 
                    check = false;
                }
                else
                {
                    check = true;
                }
            }


            MajVoting(ref binarymessage);
            Console.ReadKey();
        }
        static void MajVoting(ref string binarymessage)
        {
            string binaryone = binarymessage;
            string binarytwo = binarymessage;
            string binarythree = binarymessage;
            string parity = "";
            string binarytrue = "";

            Console.WriteLine("Receiver one: " + binaryone);
            Console.WriteLine("Receiver two: " + binarytwo);
            Console.WriteLine("Receiver three: " + binarythree);

            if (binaryone == binarytwo || binaryone == binarythree)
            {
                binarytrue = binaryone;
                
            }
            else if (binarytwo == binaryone || binarytwo == binarythree)
            {
                binarytrue = binarytwo;
            }

            Console.WriteLine("To check if your message is valid, please select ODD or EVEN parity");
            parity = Console.ReadLine().ToUpper();
            Console.WriteLine("Do you wish to add an additional parity bit? Yes / No ");
            string yesno = Console.ReadLine().ToUpper();
            if (yesno == "YES")
            {
                Console.WriteLine("Please insert your parity bit. (1 or 0 )");
                string paritybit = Console.ReadLine();
                binarytrue = binarytrue + paritybit;
            }
            bool paritycheck = Paritybit(ref binarytrue, ref parity);
            if (paritycheck == true)
            {
                Console.Write("Your message is: ");
                if (yesno == "YES")
                {
                    for (int i = 0; i < binarytrue.Length - 1; i++)
                    {
                        Console.Write(binarytrue[i]);
                    }

                }
                if (yesno == "NO")
                {
                    Console.Write(binarytrue);
                }
            }
            else if (paritycheck == false)
            {
                Console.WriteLine("Your message was not received correctly");
                Console.Write("(ERROR in parity bit check)");
            }

        }

        static bool Paritybit(ref string binarytrue,  ref string parity)
        {
            int one = 0;
            bool paritycheck = false;
            for (int i = 0; i < binarytrue.Length; i++)
            {
                if (binarytrue[i] == '1')
                {
                    one ++;
                }
            }
            if (parity == "ODD" && one % 2 == 1)
            {
                paritycheck = true;
            }

            if (parity == "EVEN" && one % 2 == 0)
            {
                paritycheck = true;
            }
            return paritycheck;
        }
    }
}
