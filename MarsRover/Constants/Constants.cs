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
    public class Constants
    {
        /// <summary>
        /// W: West
        /// </summary>
        public static readonly string WestDirection = "W";

        /// <summary>
        /// E: East
        /// </summary>
        public static readonly string EastDirection = "E";

        /// <summary>
        /// S: South
        /// </summary>
        public static readonly string SouthDirection = "S";

        /// <summary>
        /// N: North
        /// </summary>
        public static readonly string NorthDirection = "N";

        //Stores the represented classes for each direction letter
        public static readonly Dictionary<string, Type> DirectionClassNames = new Dictionary<string, Type>()
        {
            { "W",typeof(WestDirectionCommands)},
            { "E",typeof(EastDirectionCommands)},
            { "S",typeof(SouthDirectionCommands)},
            { "N",typeof(NorthDirectionCommands)},
        };
    }
}
