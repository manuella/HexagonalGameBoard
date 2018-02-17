using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexCoordinates.Coordinates
{
    public class Cubic : Coordinate
    {
        private int _x;
        public int X
        {
            get { return _x;  }
        }

        private int _y;
        public int Y
        {
            get { return _y; }
        }

        public int Z
        {
            get { return _z; }
        }
        private int _z;

        private Orientation _orientation = Orientation.FLAT_TOP;

        public Cubic(int x, int y, int z, Orientation orient, Scew scewIn)
        {
            _x = x;
            _y = y;
            _z = z;

            orientation = orient;
            scew = scewIn;
        }

        public Orientation orientation
        {
            get
            {
                return _orientation;
            }

            set
            {
                _orientation = value;
            }
        }

        private Scew _scew = Scew.even;

        public Scew scew
        {
            get
            {
                return _scew;
            }

            set
            {
                _scew = value;
            }
        }

        public IList<Coordinate> GetNeighbors()
        {
            return new List<Coordinate>();
        }

        public Coordinate GetNeighbor(Direction direction)
        {
            Cubic neighbor;

            if (this.orientation == Orientation.CORNER_TOP)
            {
                neighbor = (Cubic)GetNeighborCornerTop(direction);
            }
            else
            {
                neighbor = (Cubic)GetNeighborFlatTop(direction);
            }



            return neighbor;
        }

        private Coordinate GetNeighborCornerTop(Direction direction)
        {
            int newX = 0;
            int newY = 0;
            int newZ = 0;

            switch (direction)
            {
                case Direction.NORTHEAST:
                    newX = _x + 1;
                    newY = _y;
                    newZ = _z - 1;
                    break;
                case Direction.NORTHWEST:
                    newX = _x;
                    newY = _y + 1;
                    newZ = _z - 1;
                    break;
                case Direction.SOUTHEAST:
                    newX = _x;
                    newY = _y - 1;
                    newZ = _z + 1;
                    break;
                case Direction.SOUTHWEST:
                    newX = _x + 1;
                    newY = _y;
                    newZ = _z - 1;
                    break;
                case Direction.EAST:
                    newX = _x + 1;
                    newY = _y - 1;
                    newZ = _z;
                    break;
                case Direction.WEST:
                    newX = _x - 1;
                    newY = _y + 1;
                    newZ = _z;
                    break;
                default:
                    throw new NoAdjacentHexException(direction.ToString());

            }
            return new Cubic(newX, newY, newZ, this.orientation, this.scew);
        }

        private Coordinate GetNeighborFlatTop(Direction direction)
        {
            int newX = 0;
            int newY = 0;
            int newZ = 0;

            switch (direction)
            {
                case Direction.NORTHEAST:
                    newX = _x + 1;
                    newY = _y;
                    newZ = _z - 1;
                    break;
                case Direction.NORTHWEST:
                    newX = _x - 1;
                    newY = _y + 1;
                    newZ = _z;
                    break;
                case Direction.SOUTHEAST:
                    newX = _x + 1;
                    newY = _y - 1;
                    newZ = _z;
                    break;
                case Direction.SOUTHWEST:
                    newX = _x - 1;
                    newY = _y;
                    newZ = _z + 1;
                    break;
                case Direction.NORTH:
                    newX = _x;
                    newY = _y + 1;
                    newZ = _z - 1;
                    break;
                case Direction.SOUTH:
                    newX = _x;
                    newY = _y - 1;
                    newZ = _z + 1;
                    break;
                default:
                    throw new NoAdjacentHexException(direction.ToString());

            }
            return new Cubic(newX, newY, newZ, this.orientation, this.scew);
        }

    }
}

