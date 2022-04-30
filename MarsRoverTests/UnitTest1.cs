using MarsRover.ApplicationBase;
using MarsRover.Models;
using NUnit.Framework;
using System;

namespace MarsRoverTests
{
    public class Tests
    {
        private Application app;
        [SetUp]
        public void Setup()
        {
            app = new Application
            {
                Plateau = new Plateau
                {
                    Position = new Position
                    {
                        XCoordinate = 5,
                        YCoordinate = 5
                    }
                }
            };
        }

        [Test]
        public void Test1()
        {
            var rover = new Rover
            {
                Position = new Position
                {
                    XCoordinate = 1,
                    YCoordinate = 2
                },
                Direction = Direction.N
            };
            app.Rover = rover;
            app.Process("LMLMLMLMM");
            Assert.AreEqual("1 3 N", rover.ToString());
        }

        [Test]
        public void Test2()
        {
            var rover = new Rover
            {
                Position = new Position
                {
                    XCoordinate = 3,
                    YCoordinate = 3
                },
                Direction = Direction.E
            };
            app.Rover = rover;
            app.Process("MMRMMRMRRM");
            Assert.AreEqual("5 1 E", rover.ToString());
        }

        [Test]
        public void Test3()
        {
            var rover = new Rover
            {
                Position = new Position
                {
                    XCoordinate = 3,
                    YCoordinate = 3
                },
                Direction = Direction.E
            };
            app.Rover = rover;
            Assert.Throws<InvalidOperationException>(() => app.Process("MMMMMM"));
        }
    }
}