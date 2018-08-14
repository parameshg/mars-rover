using MarsRover.Server.Commands;

namespace MarsRover.Server.Factories
{
    public class RightCommandFactory : CommandFactory
    {
        public override string Name => "RIGHT";

        public override string Description => "Turns the rover to its right";

        public RightCommandFactory(IRover rover)
            : base(rover)
        {
        }

        public override ICommand Create(params string[] args)
        {
            return new RightCommand(Rover);
        }
    }
}