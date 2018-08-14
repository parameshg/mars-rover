using MarsRover.Server.Commands;

namespace MarsRover.Server.Factories
{
    public interface ICommandFactory
    {
        string Name { get; }

        string Description { get; }

        ICommand Create(params string[] args);
    }
}