using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    /// <summary>
    /// Data Transfer Object of Robotic Rover
    /// </summary>
    public class Rover
    {
        public Position RoverPosition { get; set; }
        public Direction RoverDirection { get; set; }
        public Plateau RoverPlateau { get; set; }

        public Rover( int xCoordinate,int yCoordinate, string direction,Plateau plateau) {
            direction = string.IsNullOrEmpty(direction) ? "" : direction.Trim().ToUpper();

            if (xCoordinate < 0 || xCoordinate > plateau.Width || yCoordinate < 0 || yCoordinate > plateau.Height)
                Console.WriteLine("Rover position should be in plateau boundaries!");
            else if (string.IsNullOrEmpty(direction) || !Constants.DirectionClassNames.Any(x => x.Key == direction))
                Console.WriteLine("'" + direction.Trim().ToUpper() + "' is not a valid direction!");
            else
            {
                this.RoverPosition = new Position(xCoordinate, yCoordinate);
                this.RoverPlateau = plateau;
                this.RoverDirection = (Direction)Activator.CreateInstance(Constants.DirectionClassNames.Where(d => d.Key == direction).FirstOrDefault().Value);
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}",
                (RoverPosition == null ? "-" : RoverPosition.XCoordinate.ToString()),
                (RoverPosition == null ? "-" : RoverPosition.YCoordinate.ToString()),
                (RoverDirection == null ? "-" : RoverDirection.GetDirection()));
        }
    }
}
