using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HexCoordinates.Coordinates;

namespace HexCoordinates.Test
{
    [TestClass]
    public class TestCoordinates
    {
        [TestMethod]
        [ExpectedException(typeof(NoAdjacentHexException))]
        public void GoNorthWhenThereIsNoNorth()
        {
            Cubic origin = new Cubic(0, 0, 0, Orientation.CORNER_TOP, Scew.even);
            origin.GetNeighbor(Direction.NORTH); 
        }

        [TestMethod]
        public void GoNorth()
        {
            Cubic origin = new Cubic(0, 0, 0, Orientation.FLAT_TOP, Scew.even);
            Cubic northernNeighbor = (Cubic) origin.GetNeighbor(Direction.NORTH);
            Assert.AreEqual(northernNeighbor.Z, origin.Z - 1);
            Assert.AreEqual(northernNeighbor.Y, origin.Y + 1);
        }
    }
}
