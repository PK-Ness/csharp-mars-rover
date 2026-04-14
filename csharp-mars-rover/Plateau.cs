using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_mars_rover
{
    public class Plateau
    {
        public static int X { get; set; }
        public static int Y { get; set; }
        public static CardinalDirections Direction { get; set; }

        public static void SetPlateauCoordinates(int x, int y, CardinalDirections direction)
        {
            X = x;
            Y = y;
            Direction = direction;
            Console.WriteLine("Setting plateau dimensions.");
            int plateauX;
            int plateauY;
            bool isValid;
            do {
               
                Console.WriteLine("Enter the x-size of the plateau:");
                string xInput = Console.ReadLine();
                isValid = int.TryParse(xInput, out plateauX);
                if(!isValid || plateauX < 0)
                {
                    Console.WriteLine("Invalid input for your x-size.");
                }
                } while (!isValid || plateauX < 0);
            do
            {
                Console.WriteLine("Enter the y-size of the plateau:");
                string yInput = Console.ReadLine();
                isValid = int.TryParse(yInput, out plateauY);
                if (!isValid || plateauY < 0)
                {
                    Console.WriteLine("Invalid input for your y-size.");
                }
            } while (!isValid || plateauY < 0);
            
            Console.WriteLine($"Plateau dimensions set to: {plateauX} x {plateauY}, facing {direction}");
            

        }
    }
}
