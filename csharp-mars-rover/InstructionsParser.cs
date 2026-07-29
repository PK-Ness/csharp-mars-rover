using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_mars_rover
{
    internal class InstructionsParser
    {

        public static string ParseInstructions(string instructions)
        {
            string result = new string(instructions.
                       Where(c => Enum
                       .IsDefined(typeof(Instructions), c
                       .ToString()))
                       .ToArray());


            Console.WriteLine("Enter your instructions for rover movement (L, R, M): ");
            result = Console.ReadLine();
            foreach (char c in result)
            {
                if (result.Contains(c))
                {
                    Console.WriteLine($"Valid instruction found: {c}");
                }

             
            }
            return "Your commands are " + result;
        }
           
    }
}
