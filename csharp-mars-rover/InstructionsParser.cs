using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_mars_rover
{
    public class InstructionsParser
    {

        public static string ParseInstructions(string instructions)
        {
            string result = new string(instructions.
                       Where(c => Enum
                       .IsDefined(typeof(Instructions), c
                       .ToString()))
                       .ToArray());

            string[] finalCommands = Array.Empty<string>();
            Console.WriteLine("Enter your instructions for rover movement (L, R, M): ");
            string command = Console.ReadLine();
            foreach (char c in command)
            {
                if (c == 'L' || c == 'R' || c == 'M' || c == 'l' || c == 'r' || c == 'm')
                {
                    Console.WriteLine($"Valid instruction found: {c}");
                    finalCommands = finalCommands.Append(c.ToString()).ToArray();
                }
                
            }
            Console.WriteLine("Your commands are " + string.Join("", finalCommands).ToUpper());
            return "";
        }
           
    }
}
