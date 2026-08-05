using System.Globalization;

namespace csharp_mars_rover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string instructions = "";
            RoverPosition.Landing(false);

            Plateau.SetPlateauCoordinates(5, 5, CardinalDirections.North);

            InstructionsParser.ParseInstructions(instructions);

        }
    }
}
