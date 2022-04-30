using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Models
{
    public enum Direction
    {
        N, E, S, W
    }

    public class Rover
    {
        public Position Position { get; set; }
        public Direction Direction { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Position.XCoordinate, Position.YCoordinate, Direction);
        }
    }
}
