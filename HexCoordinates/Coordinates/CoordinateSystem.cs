using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexCoordinates.Coordinates
{
    public interface Coordinate
    {
        IList<Coordinate> GetNeighbors();
        Coordinate GetNeighbor(Direction direction);
        int GetHashCode();
        Orientation orientation { get; set; }
        Scew scew { get; set; }
        // should go on board
        //public IList<Coordinate> Line(Coordinate start, Coordinate end);
    }

    public enum Orientation { CORNER_TOP, FLAT_TOP };
    public enum Scew { odd, even };
    public enum Direction { NORTH, NORTHEAST, EAST, SOUTHEAST, SOUTH, SOUTHWEST, WEST, NORTHWEST };

}

public class NoAdjacentHexException : Exception
{
    public NoAdjacentHexException()
    {
    }

    public NoAdjacentHexException(string direction)
        : base(String.Format("No adjacent hex", direction))
    {
    }
}
