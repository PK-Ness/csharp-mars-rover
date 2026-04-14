using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_mars_rover
{
    public class InstructionsParser
    {
        
        public string ParseInstructions(string instructions)
        {
             string result = new string(instructions.
                    Where(c => Enum
                    .IsDefined(typeof(Instructions), c
                    .ToString()))
                    .ToArray());

            return result;
        }
     }
        
  }
