using System;
using System.Drawing;

namespace MarsRover.Server.Commands
{
    public class ReportCommand : Command
    {
        public Tuple<Point, Direction> Result { get; private set; }

        public ReportCommand(IRover rover)
            : base(rover)
        {
        }

        public override bool Validate()
        {
            return Rover != null;
        }

        public override void Execute()
        {
            Result = new Tuple<Point, Direction>(Rover.Position, Rover.Direction);

            Console.WriteLine($"{Rover.Position.X},{Rover.Position.Y},{Rover.Direction}");
        }
    }
}