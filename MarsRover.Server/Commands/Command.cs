namespace MarsRover.Server.Commands
{
    public abstract class Command : ICommand
    {
        public IRover Rover { get; }

        public Command(IRover rover)
        {
            Rover = rover;
        }

        public abstract bool Validate();

        public abstract void Execute();
    }
}