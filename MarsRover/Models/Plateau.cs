using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Models
{
    public class Plateau
    {
        public Position Position { get; set; }

        public override string ToString()
        {
            return string.Format("coordinates: 0, 0 up to {0}, {1}", Position.XCoordinate, Position.YCoordinate);
        }
    }
}
