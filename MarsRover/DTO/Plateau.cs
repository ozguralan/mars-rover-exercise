using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    /// <summary>
    /// Plateau
    /// </summary>
    public class Plateau
    {
        /// <summary>
        /// Width of Plateau
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Height of Plateau
        /// </summary>
        public int Height { get; set; }

        public Plateau(int width,int height) {
            if (width <= 0)
                Console.WriteLine("You can only give positive number for width of plateau!");
            else if (height <= 0)
                Console.WriteLine("You can only give positive number for height of plateau!");
            else
            {
                this.Width = width;
                this.Height = height;
            }
        }
    }
}
