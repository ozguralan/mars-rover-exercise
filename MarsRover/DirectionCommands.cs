using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    /// <summary>
    /// Commands Implementation For Each Directions
    /// </summary>
    public abstract class Direction
    {
        public abstract void Move(ref Rover rover);
        public abstract void TurnLeft(ref Rover rover);
        public abstract void TurnRight(ref Rover rover);

        public abstract string GetDirection();

        public bool IsRoverInPlateauBoundaries(Position position, Plateau plateau) {
            if (position.XCoordinate >= 0 && position.XCoordinate <= plateau.Width && position.YCoordinate >= 0 && position.YCoordinate <= plateau.Height)
                return true;
            else {
                Console.WriteLine("Rover will be outside of plateau boundaries,command couldn't processed!");
                return false;
            }
        }
    }

    /// <summary>
    /// Commands For West Direction
    /// </summary>
    public class WestDirectionCommands : Direction
    {
        public override void Move(ref Rover rover)
        {
            Position newPosition = rover.RoverPosition;
            newPosition.XCoordinate -= 1;

            if (IsRoverInPlateauBoundaries(newPosition, rover.RoverPlateau))
                rover.RoverPosition = newPosition;
        }
        public override void TurnLeft(ref Rover rover)
        {
            rover.RoverDirection = new SouthDirectionCommands();
        }
        public override void TurnRight(ref Rover rover)
        {
            rover.RoverDirection = new NorthDirectionCommands();
        }
        public override string GetDirection()
        {
            return Constants.WestDirection;
        }
    }

    /// <summary>
    /// Commands For East Direction
    /// </summary>
    public class EastDirectionCommands : Direction
    {
        public override void Move(ref Rover rover)
        {
            Position newPosition = rover.RoverPosition;
            newPosition.XCoordinate += 1;

            if (IsRoverInPlateauBoundaries(newPosition, rover.RoverPlateau))
                rover.RoverPosition = newPosition;
        }
        public override void TurnLeft(ref Rover rover)
        {
            rover.RoverDirection = new NorthDirectionCommands();
        }
        public override void TurnRight(ref Rover rover)
        {
            rover.RoverDirection = new SouthDirectionCommands();
        }
        public override string GetDirection()
        {
            return Constants.EastDirection;
        }
    }

    public class SouthDirectionCommands : Direction
    {
        public override void Move(ref Rover rover)
        {
            Position newPosition = rover.RoverPosition;
            newPosition.YCoordinate -= 1;

            if (IsRoverInPlateauBoundaries(newPosition, rover.RoverPlateau))
                rover.RoverPosition = newPosition;
        }
        public override void TurnLeft(ref Rover rover)
        {
            rover.RoverDirection = new EastDirectionCommands();
        }
        public override void TurnRight(ref Rover rover)
        {
            rover.RoverDirection = new WestDirectionCommands();
        }
        public override string GetDirection()
        {
            return Constants.SouthDirection;
        }
    }

    public class NorthDirectionCommands : Direction
    {
        public override void Move(ref Rover rover)
        {
            Position newPosition = rover.RoverPosition;
            newPosition.YCoordinate += 1;

            if (IsRoverInPlateauBoundaries(newPosition, rover.RoverPlateau))
                rover.RoverPosition = newPosition;
        }
        public override void TurnLeft(ref Rover rover)
        {
            rover.RoverDirection = new WestDirectionCommands();
        }
        public override void TurnRight(ref Rover rover)
        {
            rover.RoverDirection = new EastDirectionCommands();
        }
        public override string GetDirection()
        {
            return Constants.NorthDirection;
        }
    }
}
