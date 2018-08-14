using MarsRover.Server.Commands;

namespace MarsRover.Server.Factories
{
    public class MoveCommandFactory : CommandFactory
    {
        public override string Name => "MOVE";

        public override string Description => "Moves the rover one step in its facing direction";

        public MoveCommandFactory(IRover rover)
            : base(rover)
        {
        }

        public override ICommand Create(params string[] args)
        {
            return new MoveCommand(Rover);
        }
    }
}