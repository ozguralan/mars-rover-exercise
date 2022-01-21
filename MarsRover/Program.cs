using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            //Main command executer class to process each command
            CommandExecuter commandExecuter = new CommandExecuter();


            Plateau plateau = new Plateau(5, 5);
            Rover rover1 = new Rover(1, 2, "N", plateau);
            commandExecuter.ProcessCommand(ref rover1,"LMLMLMLMM");
            Console.WriteLine(rover1.ToString());

            Rover rover2 = new Rover(3, 3, "E", plateau);
            commandExecuter.ProcessCommand(ref rover2, "MMRMMRMRRM");
            Console.WriteLine(rover2.ToString());

            Console.ReadLine();
        }

    }
}
