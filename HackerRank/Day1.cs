using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Day1
    {
        public static void ReadAndPrint()
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";
        
            // Declare second integer, double, and String variables.
            string userInput = null;
            
            // Read and save an integer, double, and String to your variables.
            int parsedInt = 0;
            double parsedDouble = 0;
            string stringInput = null;

            int.TryParse(Console.ReadLine(), out parsedInt);
            double.TryParse(Console.ReadLine(), out parsedDouble);
            stringInput = Console.ReadLine();
            
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + parsedInt);
                                    
            // Print the sum of the double variables on a new line.
            Console.WriteLine((d + parsedDouble).ToString());
            
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine($"{s}{stringInput}");
        }
    }
}