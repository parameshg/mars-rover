namespace MarsRover.Server.Commands
{
    public class RightCommand : Command
    {
        public RightCommand(IRover rover)
            : base(rover)
        {
        }

        public override bool Validate()
        {
            return Rover != null;
        }

        public override void Execute()
        {
            Rover.TurnRight();
        }
    }
}