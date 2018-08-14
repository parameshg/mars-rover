using MarsRover.Server.Commands;

namespace MarsRover.Server.Factories
{
    public class ReportCommandFactory : CommandFactory
    {
        public override string Name => "REPORT";

        public override string Description => "Reports the current position of the rover";

        public ReportCommandFactory(IRover rover)
            : base(rover)
        {
        }

        public override ICommand Create(params string[] args)
        {
            return new ReportCommand(Rover);
        }
    }
}