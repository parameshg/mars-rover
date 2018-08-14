using MarsRover.Server.Commands;

namespace MarsRover.Server.Factories
{
    public abstract class CommandFactory : ICommandFactory
    {
        protected IRover Rover { get; }

        public abstract string Name { get; }

        public abstract string Description { get; }

        public CommandFactory(IRover rover)
        {
            Rover = rover;
        }

        public abstract ICommand Create(params string[] args);
    }
}