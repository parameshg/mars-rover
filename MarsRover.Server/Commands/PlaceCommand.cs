using System.Drawing;

namespace MarsRover.Server.Commands
{
    public class PlaceCommand : Command
    {
        private Point Position { get; }

        private Direction Direction { get; }

        public PlaceCommand(IRover rover, Point position, Direction direction)
            : base(rover)
        {
            Position = position;
            Direction = direction;
        }

        public override bool Validate()
        {
            return Rover != null && !Rover.Area.IsEmpty && Position.X >= 0 && Position.X <= Rover.Area.Width - 1 && Position.Y >= 0 && Position.Y <= Rover.Area.Height - 1;
        }

        public override void Execute()
        {
            Rover.Stand(Position, Direction);
        }
    }
}