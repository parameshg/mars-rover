using MarsRover.Server.Commands;

namespace MarsRover.Server.Factories
{
    public class LeftCommandFactory : CommandFactory
    {
        public override string Name => "LEFT";

        public override string Description => "Turns the rover to its left";

        public LeftCommandFactory(IRover rover)
            : base(rover)
        {
        }

        public override ICommand Create(params string[] args)
        {
            return new LeftCommand(Rover);
        }
    }
}