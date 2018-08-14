using MarsRover.Server;
using MarsRover.Server.Commands;
using MarsRover.Server.Factories;
using NUnit.Framework;

namespace MarsRover.Test
{
    [TestFixture]
    public class CommandFactoryTest
    {
        [Test]
        public void TestLeftCommandFactory()
        {
            var rover = new Rover();

            var factory = new LeftCommandFactory(rover);

            var cmd = factory.Create("LEFT");

            Assert.IsTrue(cmd is LeftCommand);
        }

        [Test]
        public void TestRightCommandFactory()
        {
            var rover = new Rover();

            var factory = new RightCommandFactory(rover);

            var cmd = factory.Create("RIGHT");

            Assert.IsTrue(cmd is RightCommand);
        }

        [Test]
        public void TestPlaceCommandFactory()
        {
            var rover = new Rover();

            var factory = new PlaceCommandFactory(rover);

            var cmd = factory.Create("PLACE", "1", "1", "NORTH");

            Assert.IsTrue(cmd is PlaceCommand);
        }

        [Test]
        public void TestMoveCommandFactory()
        {
            var rover = new Rover();

            var factory = new MoveCommandFactory(rover);

            var cmd = factory.Create("MOVE");

            Assert.IsTrue(cmd is MoveCommand);
        }

        [Test]
        public void TestReportCommandFactory()
        {
            var rover = new Rover();

            var factory = new ReportCommandFactory(rover);

            var cmd = factory.Create("REPORT");

            Assert.IsTrue(cmd is ReportCommand);
        }
    }
}