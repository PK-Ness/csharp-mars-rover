using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_mars_rover
{
    internal class RoverPosition
    {
        private bool LandingMessage = false;
        public static void Landing(bool landingMessage)
        {
            if(!landingMessage)
            {
                Console.WriteLine("Rover has landed on Mars.");
                landingMessage = true;
            }
        }
        public static void RoverMove()
        {
           
        }
    }
}
