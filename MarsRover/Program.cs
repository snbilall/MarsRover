using MarsRover.ApplicationBase;
using MarsRover.Models;
using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Start Program ---");
            var plateau = new Plateau
            {
                Position = new Position
                {
                    XCoordinate = 5,
                    YCoordinate = 5
                }
            };

            var rover1 = new Rover
            {
                Position = new Position
                {
                    XCoordinate = 1,
                    YCoordinate = 2
                },
                Direction = Direction.N
            };

            Console.WriteLine("Plateau position: ");
            Console.WriteLine(plateau.ToString());
            Console.WriteLine("------------------");
            Console.WriteLine("Rover 1 initial position: ");
            Console.WriteLine(rover1.ToString());
            Console.WriteLine("Commands: LMLMLMLMM");

            var app = new Application
            {
                Plateau = plateau,
                Rover = rover1
            };
            app.Process("LMLMLMLMM");
            Console.WriteLine("Rover 1 position after commands: ");
            Console.WriteLine(rover1.ToString());
            Console.WriteLine("------------------");
            var rover2 = new Rover
            {
                Position = new Position
                {
                    XCoordinate = 3,
                    YCoordinate = 3
                },
                Direction = Direction.E
            };

            Console.WriteLine("Rover 2 initial position: ");
            Console.WriteLine("Commands: MMRMMRMRRM");
            Console.WriteLine(rover2.ToString());
            app.Rover = rover2;
            app.Process("MMRMMRMRRM");
            Console.WriteLine("Rover 2 position after commands: ");
            Console.WriteLine(rover2.ToString());
            Console.WriteLine("--- End Program ---");

            Console.ReadLine();
        }
    }
}
