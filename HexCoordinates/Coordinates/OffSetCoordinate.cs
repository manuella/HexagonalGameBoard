using System;
using System.Collections.Generic;
using System.Text;

namespace HexCoordinates.Coordinates
{
    public class Offset : Coordinate
    {
        public Orientation orientation
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Scew scew
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Coordinate GetNeighbor(Direction direction)
        {
            throw new NotImplementedException();
        }

        public IList<Coordinate> GetNeighbors()
        {
            throw new NotImplementedException();
        }

        public IList<Coordinate> Neighbors(Direction direction)
        {
            throw new NotImplementedException();
        }
    }
}
