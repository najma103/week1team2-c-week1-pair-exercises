using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartianWeight
{
    class Program
    {
        /*
        In case you've ever pondered how much you weight on Mars, here's the calculation:
 	    Wm = We* 0.378
 	    where 'Wm' is the weight on Mars, and 'We' is the weight on Earth

        Write a command line program which accepts a series of Earth weights from the user  
        and displays each Earth weight as itself, and its Martian equivalent.


        C:\Users> MartianWeight  
        Enter a series of Earth weights (space-separated): 98 235 185
            
        98 lbs.on Earth, is 37 lbs.on Mars.
        235 lbs.on Earth, is 88 lbs.on Mars.
        185 lbs.on Earth, is 69 lbs.on Mars. 
        */
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a series of Earth weights (space-separated):");

                char[] separator = { ' ' };
                string[] strWeightEarth = Console.ReadLine().Split(separator);

                for (int i = 0; i < strWeightEarth.Length; i++)
                {
                    double martianWeight = double.Parse(strWeightEarth[i]) * 0.378;

                    Console.WriteLine(strWeightEarth[i] + " lbs.on Earth, is  "
                                       + (int)martianWeight + " lbs.on Mars.");
                }
            } catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e);
            }
        }
    }
}
