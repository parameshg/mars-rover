using System;

namespace MarsRover.Server.Commands
{
    public class ExitCommand : Command
    {
        public ExitCommand(IRover rover)
            : base(rover)
        {
        }

        public override bool Validate()
        {
            return Rover != null;
        }

        public override void Execute()
        {
            Environment.Exit(0);
        }
    }
}