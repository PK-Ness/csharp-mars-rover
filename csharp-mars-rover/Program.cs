namespace csharp_mars_rover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RoverPosition.Landing(false);

            Plateau.SetPlateauCoordinates(5, 5, CardinalDirections.North);
        }
    }
}
