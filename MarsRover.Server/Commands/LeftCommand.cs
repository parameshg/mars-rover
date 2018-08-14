namespace MarsRover.Server.Commands
{
    public class LeftCommand : Command
    {
        public LeftCommand(IRover rover)
            : base(rover)
        {
        }

        public override bool Validate()
        {
            return Rover != null;
        }

        public override void Execute()
        {
            Rover.TurnLeft();
        }
    }
}