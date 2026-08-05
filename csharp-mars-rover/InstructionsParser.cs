using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
            do
           {
                Console.WriteLine("Enter your instructions for rover movement (L, R, M): ");
            string command = Console.ReadLine().ToUpper();

                foreach (char c in command)
                {

                    if (c == 'L' || c == 'R' /*|| c == 'M' || c == 'l' || c == 'r' || c == 'm'*/)
                    {

                        finalCommands = finalCommands.Append(c.ToString()).ToArray();

                    }
                   if (finalCommands.Length == 0)
                    {
                        Console.WriteLine("Your input does not contain valid instructions. Please enter only L, R, or M.");
                    }
                }
                } while (finalCommands.Length == 0);
            
            Console.WriteLine("Your commands are " + string.Join("", finalCommands).ToUpper());
            return string.Join("", finalCommands).ToUpper();
            //return result;
        }
           
    }
}
