using MarsRover.Server.Commands;

namespace MarsRover.Server.Factories
{
    public class ExitCommandFactory : CommandFactory
    {
        public override string Name => "EXIT";

        public override string Description => "Exits application";

        public ExitCommandFactory(IRover rover)
            : base(rover)
        {
        }

        public override ICommand Create(params string[] args)
        {
            return new ExitCommand(Rover);
        }
    }
}