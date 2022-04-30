using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.ApplicationBase
{
    public class Application
    {
        public Plateau Plateau { get; set; }
        public Rover Rover { get; set; }

        public void Process(string commands)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case ('L'):
                        TurnLeft();
                        break;
                    case ('R'):
                        TurnRight();
                        break;
                    case ('M'):
                        Move();
                        break;
                    default:
                        throw new ArgumentException(string.Format("Invalid value: {0}", command));
                }
            }
        }

        private void TurnLeft()
        {
            Rover.Direction = (Rover.Direction - 1) < Direction.N ? Direction.W : Rover.Direction - 1;
        }

        private void TurnRight()
        {
            Rover.Direction = (Rover.Direction + 1) > Direction.W ? Direction.N : Rover.Direction + 1;
        }

        private void Move()
        {
            if (Rover.Direction == Direction.N)
            {
                Rover.Position.YCoordinate++;
            }
            else if (Rover.Direction == Direction.E)
            {
                Rover.Position.XCoordinate++;
            }
            else if (Rover.Direction == Direction.S)
            {
                Rover.Position.YCoordinate--;
            }
            else if (Rover.Direction == Direction.W)
            {
                Rover.Position.XCoordinate--;
            }

            if (CheckRoverOutOfPlateau()) 
                throw new InvalidOperationException("Out of plateau, current position: " + Rover.ToString());
        }

        private bool CheckRoverOutOfPlateau()
        {
            return Rover.Position.XCoordinate < 0 ||
                Rover.Position.XCoordinate > Plateau.Position.XCoordinate ||
                Rover.Position.YCoordinate < 0 ||
                Rover.Position.YCoordinate > Plateau.Position.YCoordinate;
        }
    }
}
