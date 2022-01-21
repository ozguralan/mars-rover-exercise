using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    /// <summary>
    /// Constants
    /// </summary>
    public class Position
    {
        /// <summary>
        /// X Coordinate
        /// </summary>
        public int XCoordinate { get; set; }

        /// <summary>
        /// Y Coordinate
        /// </summary>
        public int YCoordinate { get; set; }

        public Position(int xCoordinate,int yCoordinate) {
            this.XCoordinate = xCoordinate;
            this.YCoordinate = yCoordinate;
        }
    }
}
