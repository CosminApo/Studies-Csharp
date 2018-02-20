using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Find_the_sample_rate
{
    class Program
    {
        static void Main(string[] args)
        {
            //size = smplrate * bitd * time * channels
            Double size = 0;
            Double smplrate;
            Double bitdepth = 16;
            Double time;
            Double channels = 0;

            Console.WriteLine("What is the size of the file (in MB)?");
            size = Convert.ToDouble(Console.ReadLine());
            size = size * 1024 * 1024 * 8;

            Console.WriteLine("How long does the audio last (in secons)?");
            time = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Is the song stereo or mono?");
            string userinp = Console.ReadLine().ToUpper();
            if (userinp == "MONO")
            {
                channels = 1;
            }
            else if (userinp == "STEREO")
            {
                channels = 2;
            }
            smplrate = ((size / bitdepth)/ time) / channels;
            Console.WriteLine("The sample rate of a {0} song, lasting {1} second(s) and of size {2} bits is {3} hz", userinp, time, size, smplrate);
            Console.ReadKey();
        }
    }
}
