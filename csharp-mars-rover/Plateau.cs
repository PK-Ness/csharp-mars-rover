using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_mars_rover
{
    internal class Plateau
    {
        public int[] PlateauCoordinates { get; private set; } = new int[3];

        public void SetPlateauCoordinates(int x, int y, CardinalDirections direction)
        {
            PlateauCoordinates[0] = x;
            PlateauCoordinates[1] = y;
            PlateauCoordinates[2] = (int)direction;  
        }
    }
}
