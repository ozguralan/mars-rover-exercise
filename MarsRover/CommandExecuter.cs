using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    /// <summary>
    /// Command Executer
    /// </summary>
    public class CommandExecuter
    {
        private void move(ref Rover rover)
        {
            rover.RoverDirection.Move(ref rover);
        }
        private void turnLeft(ref Rover rover)
        {
            rover.RoverDirection.TurnLeft(ref rover);
        }
        private void turnRight(ref Rover rover)
        {
            rover.RoverDirection.TurnRight(ref rover);
        }

        public void ProcessCommand(ref Rover rover,string command)
        {
            if (string.IsNullOrEmpty(command))
            {
                Console.WriteLine("You should give non-empty valid command!");
                return;
            }
            if (rover == null || rover.RoverDirection == null || rover.RoverPlateau == null || rover.RoverPosition == null)
            {
                Console.WriteLine("You should give valid rover to process command!");
                return;
            }
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == 'M')
                    move(ref rover);
                else if (command[i] == 'L')
                    turnLeft(ref rover);
                else if (command[i] == 'R')
                    turnRight(ref rover);
                else
                    Console.WriteLine("'"+ command[i] + "' command is not a valid command!");
            }
        }
    }
}
