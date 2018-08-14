using MarsRover.Server;
using MarsRover.Server.Commands;
using NUnit.Framework;
using System.Drawing;

namespace MarsRover.Test
{
    [TestFixture]
    public class CommandExecutorTest
    {
        [Test]
        public void TestPlaceCommandExecution()
        {
            var rover = new Rover();

            var executor = new CommandExecutor();

            var cmd = new PlaceCommand(rover, new Point(1, 1), Direction.NORTH);

            executor.Execute(cmd);

            Assert.AreEqual(rover.Position.X, 1);
            Assert.AreEqual(rover.Position.Y, 1);
            Assert.AreEqual(rover.Direction, Direction.NORTH);
        }

        [Test]
        public void TestCheckForInitialPlaceCommand()
        {
            var rover = new Rover();

            var executor = new CommandExecutor();

            var cmd = new MoveCommand(rover);

            executor.Execute(cmd);

            Assert.AreEqual(rover.Position.X, 0);
            Assert.AreEqual(rover.Position.Y, 0);
            Assert.AreEqual(rover.Direction, Direction.NORTH);
        }
    }
}