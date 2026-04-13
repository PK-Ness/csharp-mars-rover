using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_mars_rover
{
    public class Rover
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
            int[] plateau = new int[2];
            plateau[0] = 0;
            plateau[1] = 0;
            CardinalDirections direction = CardinalDirections.North;
            RotateDirection rotateDirection;
            string command = "";
            string rotateCommand = "";
            do
            {
                Console.WriteLine("What is your next command? (Move/Rotate)");
                command = Console.ReadLine().ToLower();
           
            
            if (command == "move")
            {
                plateau[0] = 0;
                plateau[1] += 1;
            }
            if(command == "rotate")
            {
                do
                {
                    Console.WriteLine("Which direction would you like to rotate? (Left/Right)");
                     rotateCommand = Console.ReadLine().ToLower();
                } while (rotateCommand != "left" && rotateCommand != "right");
                if(rotateCommand == "left")
                {
                    rotateDirection = RotateDirection.Left;
                    direction = (CardinalDirections)(((int)direction + 3) % 4);
                }
                if(rotateCommand == "right")
                {
                    rotateDirection = RotateDirection.Right;
                    direction = (CardinalDirections)(((int)direction + 1) % 4);
                }
            }

            } while (command != "move" && command != "rotate");
        }
    }
}
