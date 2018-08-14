using MarsRover.Server;
using MarsRover.Server.Commands;
using NUnit.Framework;
using System.Drawing;

namespace MarsRover.Test
{
    [TestFixture]
    public class CommandTest
    {
        [Test]
        public void TestLeftCommand()
        {
            var rover = new Rover();

            rover.Stand(new Point(1, 1), Direction.NORTH);

            var cmd = new LeftCommand(rover);

            Assert.IsTrue(cmd.Validate());

            cmd.Execute();

            Assert.AreEqual(rover.Position.X, 1);
            Assert.AreEqual(rover.Position.Y, 1);
            Assert.AreEqual(rover.Direction, Direction.WEST);
        }

        [Test]
        public void TestRightCommand()
        {
            var rover = new Rover();

            rover.Stand(new Point(1, 1), Direction.NORTH);

            var cmd = new RightCommand(rover);

            Assert.IsTrue(cmd.Validate());

            cmd.Execute();

            Assert.AreEqual(rover.Position.X, 1);
            Assert.AreEqual(rover.Position.Y, 1);
            Assert.AreEqual(rover.Direction, Direction.EAST);
        }

        [Test]
        public void TestMoveCommand()
        {
            var rover = new Rover();

            rover.Stand(new Point(1, 1), Direction.NORTH);

            var cmd = new MoveCommand(rover);

            Assert.IsTrue(cmd.Validate());

            cmd.Execute();

            Assert.AreEqual(rover.Position.X, 1);
            Assert.AreEqual(rover.Position.Y, 2);
            Assert.AreEqual(rover.Direction, Direction.NORTH);
        }

        [Test]
        public void TestInvalidMoveCommand()
        {
            var rover = new Rover();

            rover.Stand(new Point(4, 4), Direction.NORTH);

            var cmd = new MoveCommand(rover);

            Assert.IsFalse(cmd.Validate());
        }

        [Test]
        public void TestPlaceCommand()
        {
            var rover = new Rover();

            var cmd = new PlaceCommand(rover, new Point(1, 1), Direction.NORTH);

            Assert.IsTrue(cmd.Validate());

            cmd.Execute();

            Assert.AreEqual(rover.Position.X, 1);
            Assert.AreEqual(rover.Position.Y, 1);
            Assert.AreEqual(rover.Direction, Direction.NORTH);
        }

        [Test]
        public void TestInvalidPlaceCommand()
        {
            var rover = new Rover();

            var cmd = new PlaceCommand(rover, new Point(10, 12), Direction.NORTH);

            Assert.IsFalse(cmd.Validate());
        }

        [Test]
        public void TestReportCommand()
        {
            var rover = new Rover();

            rover.Stand(new Point(1, 1), Direction.NORTH);

            var cmd = new ReportCommand(rover);

            Assert.IsTrue(cmd.Validate());

            cmd.Execute();

            Assert.AreEqual(cmd.Result.Item1.X, 1);
            Assert.AreEqual(cmd.Result.Item1.Y, 1);
            Assert.AreEqual(cmd.Result.Item2, Direction.NORTH);
        }
    }
}