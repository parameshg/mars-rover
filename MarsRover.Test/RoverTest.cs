using MarsRover.Server;
using NUnit.Framework;
using System;
using System.Drawing;

namespace MarsRover.Test
{
    [TestFixture]
    public class RoverTest
    {
        [Test]
        public void TestRoverInitialization()
        {
            var rover = new Rover();

            Assert.AreEqual(rover.Area.Width, 5);
            Assert.AreEqual(rover.Area.Height, 5);
            Assert.AreEqual(rover.Position.X, 0);
            Assert.AreEqual(rover.Position.Y, 0);
            Assert.AreEqual(rover.Direction, Direction.NORTH);
        }

        [Test]
        public void TestIfRoverCanBePlacedOnValidPositionAndDirection()
        {
            var rover = new Rover();

            rover.Stand(new Point(2, 3), Direction.SOUTH);

            Assert.AreEqual(rover.Position.X, 2);
            Assert.AreEqual(rover.Position.Y, 3);
            Assert.AreEqual(rover.Direction, Direction.SOUTH);
        }

        [Test]
        public void TestIfRoverThrowsErrorOnInvalidPosition()
        {
            var rover = new Rover();

            Assert.Throws<ApplicationException>(() =>
            {
                rover.Stand(new Point(10, 12), Direction.WEST);
            });
        }

        [Test]
        public void TestIfRoverTurnsRight()
        {
            var rover = new Rover();

            rover.Stand(new Point(1, 1), Direction.NORTH);

            rover.TurnRight();

            Assert.AreEqual(rover.Position.X, 1);
            Assert.AreEqual(rover.Position.Y, 1);
            Assert.AreEqual(rover.Direction, Direction.EAST);
        }

        [Test]
        public void TestIfRoverTurnsLeft()
        {
            var rover = new Rover();

            rover.Stand(new Point(1, 1), Direction.NORTH);

            rover.TurnLeft();

            Assert.AreEqual(rover.Position.X, 1);
            Assert.AreEqual(rover.Position.Y, 1);
            Assert.AreEqual(rover.Direction, Direction.WEST);
        }

        [Test]
        public void TestIfRoverMovesForwardOnXAxis()
        {
            var rover = new Rover();

            rover.Stand(new Point(1, 1), Direction.EAST);

            rover.Move();

            Assert.AreEqual(rover.Position.X, 2);
            Assert.AreEqual(rover.Position.Y, 1);
            Assert.AreEqual(rover.Direction, Direction.EAST);
        }

        [Test]
        public void TestIfRoverMovesBackwardsOnXAxis()
        {
            var rover = new Rover();

            rover.Stand(new Point(1, 1), Direction.WEST);

            rover.Move();

            Assert.AreEqual(rover.Position.X, 0);
            Assert.AreEqual(rover.Position.Y, 1);
            Assert.AreEqual(rover.Direction, Direction.WEST);
        }

        [Test]
        public void TestIfRoverMovesForwardOnYAxis()
        {
            var rover = new Rover();

            rover.Stand(new Point(1, 1), Direction.NORTH);

            rover.Move();

            Assert.AreEqual(rover.Position.X, 1);
            Assert.AreEqual(rover.Position.Y, 2);
            Assert.AreEqual(rover.Direction, Direction.NORTH);
        }

        [Test]
        public void TestIfRoverMovesBackwardsOnYAxis()
        {
            var rover = new Rover();

            rover.Stand(new Point(1, 1), Direction.SOUTH);

            rover.Move();

            Assert.AreEqual(rover.Position.X, 1);
            Assert.AreEqual(rover.Position.Y, 0);
            Assert.AreEqual(rover.Direction, Direction.SOUTH);
        }

        [Test]
        public void TestIfRoverThrowsErrorIfMadeToFall()
        {
            var rover = new Rover();

            rover.Stand(new Point(4, 4), Direction.NORTH);

            Assert.Throws<ApplicationException>(() =>
            {
                rover.Move();
            });
        }
    }
}