using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_mars_rover
{
    internal class Rover
    {
        private bool LandingMessage = false;
        public int[] Plateau { get; private set; } = new int[3];

        public void SetPlateau(int x, int y, CardinalDirections cardinalDirections)
        {
            Plateau[0] = x;
            Plateau[1] = y;
            Plateau[2] = (int)cardinalDirections;
        }
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
            int x = 0;
            int y = 0; 
            CardinalDirections direction = CardinalDirections.North;
            string command = "";
            string rotateCommand = "";

            while (command != "move" && command != "rotate")
            {


                Console.WriteLine("What is your next command? (Move/Rotate)");
                command = Console.ReadLine().ToLower();

                if (command == "move" && direction == CardinalDirections.North)
                {
                    x = 0;
                    y += 1;
                    Console.WriteLine($"Rover is now at coordinates ({x}, {y}) facing {(CardinalDirections)direction}.");
                }
                if (command == "rotate")
                {
                    do
                    {
                        Console.WriteLine("Which direction would you like to rotate? (Left/Right)");
                        rotateCommand = Console.ReadLine().ToLower();
                    } while (rotateCommand != "left" && rotateCommand != "right");
                    if (rotateCommand == "left")
                    {
                        direction = (CardinalDirections)(((int)direction + 3) % 4);
                        //Console.WriteLine($"Rover is now at coordinates ({plateau[0]}, {plateau[1]}) facing {direction}.");
                    }
                    if (rotateCommand == "right")
                    {

                        direction = (CardinalDirections)(((int)direction + 1) % 4);
                    }
                }

            }
        }
    }
}
