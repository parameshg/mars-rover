using MarsRover.Server;
using MarsRover.Server.Commands;
using NUnit.Framework;

namespace MarsRover.Test
{
    [TestFixture]
    public class CommandParserTest
    {
        [Test]
        public void TestPlaceCommandParser()
        {
            var rover = new Rover();

            var parser = new CommandParser(rover);

            var cmd = parser.Parse("PLACE 1,1,NORTH");

            Assert.IsTrue(cmd is PlaceCommand);
        }

        [Test]
        public void TestLeftCommandParser()
        {
            var rover = new Rover();

            var parser = new CommandParser(rover);

            var cmd = parser.Parse("LEFT");

            Assert.IsTrue(cmd is LeftCommand);
        }

        [Test]
        public void TestRightCommandParser()
        {
            var rover = new Rover();

            var parser = new CommandParser(rover);

            var cmd = parser.Parse("RIGHT");

            Assert.IsTrue(cmd is RightCommand);
        }

        [Test]
        public void TestMoveCommandParser()
        {
            var rover = new Rover();

            var parser = new CommandParser(rover);

            var cmd = parser.Parse("MOVE");

            Assert.IsTrue(cmd is MoveCommand);
        }

        [Test]
        public void TestReportCommandParser()
        {
            var rover = new Rover();

            var parser = new CommandParser(rover);

            var cmd = parser.Parse("REPORT");

            Assert.IsTrue(cmd is ReportCommand);
        }

        [Test]
        public void TestInvalidCommandParser()
        {
            var rover = new Rover();

            var parser = new CommandParser(rover);

            var cmd = parser.Parse("NON-EXISTING-COMMAND");

            Assert.IsTrue(cmd is InvalidCommand);
        }
    }
}